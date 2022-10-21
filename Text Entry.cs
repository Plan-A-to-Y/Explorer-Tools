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
    public partial class Text_Entry : UserControl
    {
        public string FilePath { get; }
        public Text_Entry()
        {
            InitializeComponent();
        }
        public Text_Entry(string filePath)
        {
            FilePath = filePath;
            InitializeComponent();
        }
        private void TextEntry_Load(object sender, EventArgs e)
        {
            lb_FileName.Text = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
            rtb_Content.Text = File.ReadAllText(FilePath);
            btn_Save.Hide();
            btn_Save.Height = 0;
        }

        private void rtb_Content_TextChanged(object sender, EventArgs e)
        {
            btn_Save.Show();
            btn_Save.Height = 20;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FilePath, rtb_Content.Text);
            btn_Save.Hide();
            btn_Save.Height = 0;
        }
    }
}
