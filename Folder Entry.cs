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
    }
}
