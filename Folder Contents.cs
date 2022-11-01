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
    public partial class Folder_Contents : Form, IDisplayForm
    {
        md_Folder md;
        string Dir;
        public IFileIcon SelectedFile;
        public List<string> ImageTypes = new List<string> { ".bmp", ".png", ".jpg", ".jpeg", ".gif" };
        public List<string> TextTypes = new List<string> { ".txt" };
        public List<string> DocTypes = new List<string> { ".docx" };

        bool Moving = false;
        Point offset;

        public Folder_Contents()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        public void DisplayContents(string Path)
        {
            if (Metadata.FolderMetadata.Exists(x => x.FolderPath.Equals(Path))) { md = Metadata.FolderMetadata.Find(x => x.FolderPath.Equals(Path)); }
            else Metadata.FolderMetadata.Add(new md_Folder(Path));
            Dir = Path;
            foreach (string file in Directory.GetFiles(Dir))
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
        bool ResizeBottom = false;
        bool ResizeActive = false;
        int[] Cell = new int[2];
        int XCoord;
        int YCoord;
        private void tableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            offset = new Point(e.X, e.Y);
            ResizeActive = true;
        }

        private void tableLayoutPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            Point Pos = panel_Content.PointToClient(tableLayoutPanel2.PointToScreen(e.Location));
            if (Pos.X < 0 ) { Cell[0] = 0; }
            else if (Pos.X > panel_Content.Width ) { Cell[0] = 2; }
            else { Cell[0] = 1; }
            if (Pos.Y > panel_Content.Height) { Cell[1] = 1; }
            else { Cell[1] = 0; }
            
            if (Cell[0] == 0 && Cell[1] == 0) { ResizeLeft = true; Cursor.Current = Cursors.SizeWE; }
            else if (Cell[0] == 0 && Cell[1] == 1) { ResizeBottom = true; ResizeLeft = true; Cursor.Current = Cursors.SizeNESW; }
            else if (Cell[0] == 1 && Cell[1] == 1) { ResizeBottom = true; Cursor.Current = Cursors.SizeNS; }
            else if (Cell[0] == 2 && Cell[1] == 1) { ResizeBottom = true; ResizeRight = true; Cursor.Current = Cursors.SizeNWSE; }
            else if (Cell[0] == 2 && Cell[1] == 0) { ResizeRight = true; Cursor.Current = Cursors.SizeWE; }
            if (ResizeActive)
            {
                Point Movement = new Point(e.X - offset.X, 0);
                if (ResizeLeft)
                {
                    if (Movement.X > 0)
                    {
                        Location = new Point(Location.X + Movement.X, Location.Y);
                        Width -= Math.Abs(Movement.X);
                    }
                    else
                    {
                        if (Width != MinimumSize.Width) Location = new Point(Location.X + Movement.X, Location.Y);
                        Width += Math.Abs(Movement.X);
                    }
                }

                if (ResizeRight)
                {
                    Width += e.X - (Location.X + Width);
                }

                if (ResizeBottom)
                {
                    Height += e.Y - (Location.Y + Height + tableLayoutPanel2.Location.Y);
                }
            }

        }

        private void tableLayoutPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            ResizeLeft = false;
            ResizeRight = false;
            ResizeBottom = false;
            ResizeActive = false;
            Cursor.Current = Cursors.Default;
        }

        private void tableLayoutPanel2_MouseLeave(object sender, EventArgs e)
        {
            ResizeLeft = false;
            ResizeRight = false;
            ResizeBottom = false;
            Cursor.Current = Cursors.Default;
        }
    }
}
