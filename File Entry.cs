using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Explorer_Tools
{
    public partial class File_Entry : UserControl, IFileIcon
    {
        public string FilePath { get; set; }
        public IDisplayForm Owner { get; set; }
        public bool IsSelected { get; set; }
        public int FileId { get; set; }

        public File_Entry()
        {
            InitializeComponent();
        }
        public File_Entry(string filePath, IDisplayForm owner)
        {
            Owner = owner;
            FilePath = filePath;
            InitializeComponent();
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {

        }

        private void FileEntry_Load(object sender, EventArgs e)
        {
            if(Metadata.FileMetadata.Find(x => x.FilePath.Equals(FilePath)) != null)
            {
                FileId = Metadata.FileMetadata.Find(x => x.FilePath.Equals(FilePath)).FileId;
            }
            panel_MainLayout.BackColor = StyleOptions.GetColor(this, StyleOptions.colorSlot.EntryColor);
            label1.Text = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
            if (!File.Exists(FilePath)){ richTextBox1.Text = "FILE DOESN'T EXIST"; return; }
            richTextBox1.Text += $"File Extension: {FilePath.Split('.')[FilePath.Split('.').Length-1]}";
        }
        public void Selected()
        {
            ((IFileIcon)this).IsSelected = true;
            panel_MainLayout.BackColor = StyleOptions.GetColor(this, StyleOptions.colorSlot.SelectedColor);
            Owner.SelectFile(this);
        }
        public void Deselected()
        {
            ((IFileIcon)this).IsSelected = false;
            panel_MainLayout.BackColor = StyleOptions.GetColor(this, StyleOptions.colorSlot.EntryColor);
            Owner.DeselectFile(this);
        }

        public void SelectionClick(object sender, EventArgs e)
        {
            if (((IFileIcon)this).IsSelected) ((IFileIcon)this).Deselected();
            else ((IFileIcon)this).Selected();
        }
    }
}
