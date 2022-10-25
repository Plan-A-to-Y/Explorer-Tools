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
            lb_ImageProperties.Text = $"{Image.FromFile(FilePath).Width}x{Image.FromFile(FilePath).Height} ({new FileInfo(FilePath).Length}b)";
            if (File.Exists(FilePath)) isValid = true;
            else { return; }
            pb_Thumbnail.SizeMode = PictureBoxSizeMode.Zoom;
            if (FilePath.Split('.')[FilePath.Split('.').Length - 1].Equals("gif"))
            {
                pb_Thumbnail.Image = Image.FromFile(FilePath);
            }
            else { pb_Thumbnail.Image = Image.FromFile(FilePath).GetThumbnailImage(180, 180, null, IntPtr.Zero); }
        }
    }
}
