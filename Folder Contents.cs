using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Explorer_Tools
{
    public partial class Folder_Contents : Form, IDisplayForm, IFolderIcon
    {
        md_Folder md;
        public IFileIcon SelectedFile;
        public List<string> ImageTypes = new List<string> { ".bmp", ".png", ".jpg", ".jpeg", ".gif" };
        public List<string> TextTypes = new List<string> { ".txt" };
        public List<string> DocTypes = new List<string> { ".docx" };
        public bool IsSelected { get; set; }
        IDisplayForm IFolderIcon.Owner { get; set; }
        public string FolderPath { get; set; }
        public int FolderId { get; set; }

        bool Moving = false;
        Point offset;

        public Folder_Contents()
        {
            InitializeComponent();
            this.TopLevel = false;
            pn_BottomBorder.BackColor = StyleOptions.GetColor(this, StyleOptions.colorSlot.BorderColor);
            pn_TopBorder.BackColor = StyleOptions.GetColor(this, StyleOptions.colorSlot.BorderColor);
            pn_LeftBorder.BackColor = StyleOptions.GetColor(this, StyleOptions.colorSlot.BorderColor);
            pn_RightBorder.BackColor = StyleOptions.GetColor(this, StyleOptions.colorSlot.BorderColor);

            pn_TopLeft.BackColor = StyleOptions.GetColor(this, StyleOptions.colorSlot.BorderCornerColor);
            pn_TopRight.BackColor = StyleOptions.GetColor(this, StyleOptions.colorSlot.BorderCornerColor);
            pn_BottomLeft.BackColor = StyleOptions.GetColor(this, StyleOptions.colorSlot.BorderCornerColor);
            pn_BottomRight.BackColor = StyleOptions.GetColor(this, StyleOptions.colorSlot.BorderCornerColor);

        }

        public void DisplayContents(string Path)
        {
            md = Metadata.FindFolderData(Path);
            FolderId = md.FolderId;
            FolderPath = Path;
            foreach (string file in Directory.GetFiles(FolderPath))
            {
                Control iEntry;
                string ext = "." + file.Split('.').Last();
                if (ImageTypes.Contains(ext)) { iEntry = new Image_Entry(file, this); }
                else if (TextTypes.Contains(ext)) { iEntry = new Text_Entry(file, this); }
                else if (DocTypes.Contains(ext)) { iEntry = new Doc_Entry(file, this); }
                else { iEntry = new File_Entry(file, this); }
                panel_Content.Controls.Add(iEntry);
                iEntry.Show();
            }
            panel_Content.Refresh();
            label1.Text = md.DisplayName;
        }

        private void folderContents_SizeChanged(object sender, EventArgs e)
        {

        }

        public void SelectFile(IFileIcon fileIco)
        {
            if (SelectedFile != null) { SelectedFile.Deselected(); }
            SelectedFile = fileIco;
        }

        public void SelectFolder(IFolderIcon Folder)
        {
            
        }
        public void DeselectFile(IFileIcon fileIco)
        {
            if (SelectedFile != null) { SelectedFile = null; }
        }

        public void DeselectFolder(IFolderIcon Folder)
        {

        }

        private void btn_ToggleFull_Click(object sender, EventArgs e)
        {
            Dock = DockStyle.None;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel_Header_MouseDown(object sender, MouseEventArgs e)
        {
            Moving = true;
            offset = new Point(e.X, e.Y);
            panel_Header.BackColor = Color.Red;
        }

        private void Folder_Contents_MouseMove(object sender, MouseEventArgs e)
        {
            if(Moving)
            {
                Point newloc = Location;
                newloc.X += e.X - offset.X;
                newloc.Y += e.Y - offset.Y;
                Location = newloc;
            }
        }

        private void panel_Header_MouseUp(object sender, MouseEventArgs e)
        {
            if (Moving)
            {
                Moving = false;
                panel_Header.BackColor = Control.DefaultBackColor;
            }
        }

        bool ResizeLeft = false;
        bool ResizeRight = false;
        bool ResizeTop = false;
        bool ResizeBottom = false;
        bool ResizeActive = false;
        int[] Cell = new int[2];
        int XCoord;
        int YCoord;



        private void resize_MouseDown(object sender, MouseEventArgs e)
        {
            offset = new Point(e.X, e.Y);
            ResizeActive = true;
        }

        private void resize_MouseMove(object sender, MouseEventArgs e)
        {
            
            if ((sender as Panel).Name.Contains("Top")) ResizeTop = true; Cursor.Current = Cursors.SizeNS;
            if ((sender as Panel).Name.Contains("Bottom")) ResizeBottom = true; Cursor.Current = Cursors.SizeNS;
            if ((sender as Panel).Name.Contains("Left")) ResizeLeft = true; Cursor.Current = Cursors.SizeWE;
            if ((sender as Panel).Name.Contains("Right")) ResizeRight = true; Cursor.Current = Cursors.SizeWE;

            if ((ResizeRight && ResizeTop) || (ResizeLeft && ResizeBottom)) Cursor.Current = Cursors.SizeNESW;
            if ((ResizeLeft && ResizeTop) || (ResizeRight && ResizeBottom)) Cursor.Current = Cursors.SizeNWSE;

            if (ResizeActive)
            {
                Point Movement = new Point(e.X - offset.X, e.Y - offset.Y);
                if (ResizeLeft)
                {
                    if (Movement.X > 0 && Width != MinimumSize.Width)
                    {
                        Location = new Point(Location.X + Movement.X, Location.Y);
                        Width -= Math.Abs(Movement.X);
                    }
                    else if(Movement.X < 0)
                    {
                        Location = new Point(Location.X + Movement.X, Location.Y);
                        Width += Math.Abs(Movement.X);
                    }
                }

                if (ResizeRight)
                {
                    Width += Movement.X;
                }

                if (ResizeBottom)
                {
                    Height += Movement.Y;
                }
                if (ResizeTop)
                {
                    if(Height != MinimumSize.Height) Location = new Point(Location.X, Location.Y + Movement.Y);
                    Height -= Movement.Y;
                }
            }

        }

        private void Resize_MouseUp(object sender, MouseEventArgs e)
        {
            ResizeLeft = false;
            ResizeRight = false;
            ResizeBottom = false;
            ResizeTop = false;
            ResizeActive = false;
            Cursor.Current = Cursors.Default;
        }

        private void Resize_MouseLeave(object sender, EventArgs e)
        {
            ResizeLeft = false;
            ResizeRight = false;
            ResizeBottom = false;
            ResizeTop = false;
            Cursor.Current = Cursors.Default;
        }

        private void pn_TopLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_Left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_TopBorder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_TopRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_Right_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Selected()
        {
            throw new NotImplementedException();
        }

        public void Deselected()
        {
            throw new NotImplementedException();
        }
    }
}
