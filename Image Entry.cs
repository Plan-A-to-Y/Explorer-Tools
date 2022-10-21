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
    public partial class Image_Entry : UserControl
    {
        public string FilePath { get; }
        bool isValid = false;
        public Image_Entry()
        {
            InitializeComponent();

        }
        public Image_Entry(string filePath)
        {
            FilePath = filePath;
            InitializeComponent();
        }
        private void ImageEntry_Load(object sender, EventArgs e)
        {
            lb_ImageName.Text = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
            if (File.Exists(FilePath)) isValid = true;
            else { return; }
            pb_Thumbnail.Image = Image.FromFile(FilePath).GetThumbnailImage(180,180, null, IntPtr.Zero);
        }
    }
}
