using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using static Explorer_Tools.Metadata;
using System.Diagnostics;

namespace Explorer_Tools
{
    public partial class File_Entry : UserControl, IFileIcon, IRegisteredColor
    {
        public string FilePath { get; set; }
        public IDisplayForm Owner { get; set; }
        public bool IsSelected { get; set; }
        public int FileId { get; set; }
        public bool ShowDetails { get; set; }
        public Types FileType { get; set; }
        public md_File Meta;
        public File_Entry()
        {
            InitializeComponent();
        }
        public File_Entry(string filePath, IDisplayForm owner)
        {
            Owner = owner;
            FilePath = filePath;
            InitializeComponent();
            Meta = FindFileData(filePath);
            ColorRegistry.RegisterColor(new ColorReg(), this);
            UpdateVisuals();
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {

        }

        private void FileEntry_Load(object sender, EventArgs e)
        {
            if(Metadata.FileMetadata.Find(x => x.FilePath.Equals(FilePath)) != null)
            {
                FileId = Metadata.FileMetadata.Find( x => x.FilePath.Equals(FilePath)).FileId;
            }
            panel_MainLayout.BackColor = StyleOptions.GetColor(FilePath, StyleOptions.colorSlot.Background);
            lb_FileName.Text = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
            if (!File.Exists(FilePath)){ rtb_Details.Text = "FILE DOESN'T EXIST"; return; }
            rtb_Details.Text += $"File Extension: {FilePath.Split('.')[FilePath.Split('.').Length-1]}";
            if (!ShowDetails) rtb_Details.Hide();
            FileType = Metadata.GetFileType(FilePath);
            pb_Icon.Image = StyleOptions.GetIcon(Metadata.FindFileData(FilePath).IconPath);
        }

        private void ClickAndDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { 
                DoDragDrop(this, DragDropEffects.Move);
            }
        }
        public void Selected()
        {
            ((IFileIcon)this).IsSelected = true;
            panel_MainLayout.BackColor = StyleOptions.GetColor(FilePath, StyleOptions.colorSlot.Highlight);
            Owner.SelectFile(this);
        }
        public void Deselected()
        {
            ((IFileIcon)this).IsSelected = false;
            panel_MainLayout.BackColor = StyleOptions.GetColor(FilePath, StyleOptions.colorSlot.Background);
            Owner.DeselectFile(this);
        }

        public float DoubleClickTimer = 0;
        public DateTime ClickTime = DateTime.MinValue;
        private const float DoubleClickTime = 0.5f;
        public void SelectionClick(object sender, EventArgs e)
        {
            if ((DateTime.Now - ClickTime).Seconds < DoubleClickTime)
            {
                using Process fileOpen = new Process();
                fileOpen.StartInfo.FileName = "explorer";
                fileOpen.StartInfo.Arguments = $"\"{FilePath}\"";
                fileOpen.Start();
                ClickTime = DateTime.MinValue;
                return;
            }

            if (((IFileIcon)this).IsSelected) ((IFileIcon)this).Deselected();
            else ((IFileIcon)this).Selected();
            ClickTime = DateTime.Now;
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            if (!ShowDetails) { rtb_Details.Show(); ShowDetails = true; }
            else if (ShowDetails) { rtb_Details.Hide(); ShowDetails = false; }
        }

        public void UpdateVisuals()
        {
            lb_FileName.ForeColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.TextColor);
            lb_FileName.BackColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.Primary);

            btn_Details.ForeColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.TextColor);
            btn_Details.BackColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.Secondary);

            btn_Interact.ForeColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.TextColor);
            btn_Interact.BackColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.Secondary);
        }
    }
}
