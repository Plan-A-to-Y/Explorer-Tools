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
    [ToolboxItem(true)]
    public partial class FolderEntry : UserControl, IFolderIcon
    {
        public md_Folder Meta { get; }
        public bool IsSelected { get; set; }
        IDisplayForm IFolderIcon.Owner { get; set; }
        public int FolderId { get; set; }
        public string FolderPath { get; set; }
        public form_StandardView Owner;
        public FolderEntry()
        {
            this.SetTopLevel(false);
            Meta = new md_Folder(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            FolderId = Meta.FolderId;
            InitializeComponent();
        }
        public FolderEntry(string folderPath)
        {
            FolderPath = folderPath;
            this.SetTopLevel(false);
            Meta = new md_Folder(folderPath);
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Meta.IconPath);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btn_SelectFolder_Click(object sender, EventArgs e)
        {
            Folder_Contents x = new Folder_Contents();
            (TopLevelControl as form_StandardView).sc_Main.Panel2.Controls.Add(x);
            x.DisplayContents(FolderPath);
            x.Show();

        }

        private void FolderEntry_Load(object sender, EventArgs e)
        {
            this.Name = "Folder" + Meta.FolderId;
            btn_SelectFolder.Text = Meta.DisplayName;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
