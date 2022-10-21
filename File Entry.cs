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
    public partial class File_Entry : UserControl
    {
        public string FilePath { get; }
        bool isValid = false;
        public File_Entry()
        {
            InitializeComponent();
        }
        public File_Entry(string filePath)
        {
            FilePath = filePath;
            InitializeComponent();
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {

        }

        private void FileEntry_Load(object sender, EventArgs e)
        {
            label1.Text = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
            if (File.Exists(FilePath)) isValid = true;
            else { richTextBox1.Text = "FILE DOESN'T EXIST"; return; }
            richTextBox1.Text += $"File Extension: {FilePath.Split('.')[FilePath.Split('.').Length-1]}";
        }
    }
}
