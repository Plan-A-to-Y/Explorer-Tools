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
    public partial class FolderEntry : UserControl
    {
        public md_Folder Meta { get; }
        public FolderEntry()
        {
            this.SetTopLevel(false);
            Meta = new md_Folder(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            InitializeComponent();
        }
        public FolderEntry(string folderPath)
        {
            this.SetTopLevel(false);
            Meta = new md_Folder(folderPath);
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Meta.IconPath);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btn_SelectFolder_Click(object sender, EventArgs e)
        {

        }

        private void FolderEntry_Load(object sender, EventArgs e)
        {
            this.Name = "Folder" + Meta.FolderId;
            btn_SelectFolder.Text = Meta.DisplayName;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
