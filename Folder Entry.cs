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
        public string FolderPath { get; }
        public FolderEntry()
        {
            this.SetTopLevel(false);
            FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            InitializeComponent();
        }
        public FolderEntry(string folderPath)
        {
            FolderPath = folderPath;
            if (folderPath.Length <= 1) { FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); }
            InitializeComponent();
        }

        private void btn_SelectFolder_Click(object sender, EventArgs e)
        {

        }

        private void FolderEntry_Load(object sender, EventArgs e)
        {
            this.Name = FolderPath.Split('\\')[FolderPath.Split('\\').Length - 2];
            btn_SelectFolder.Text = FolderPath.Split('\\')[FolderPath.Split('\\').Length-1];
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
