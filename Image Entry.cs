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
    public partial class Image_Entry : UserControl, IFileIcon
    {
        public string FilePath { get; set; }
        public IDisplayForm Owner { get; set; }
        public bool IsSelected { get; set; }
        public int FileId { get; set; }
        public Image_Entry()
        {
            InitializeComponent();

        }
        public Image_Entry(string filePath, IDisplayForm owner)
        {
            Owner = owner;
            FilePath = filePath;
            InitializeComponent();
        }
        private void ImageEntry_Load(object sender, EventArgs e)
        {
            if (Metadata.FileMetadata.Find(x => x.FilePath.Equals(FilePath)) != null)
            {
                FileId = Metadata.FileMetadata.Find(x => x.FilePath.Equals(FilePath)).FileId;
            }
            panel_MainLayout.BackColor = StyleOptions.GetColor(FilePath, StyleOptions.colorSlot.EntryColor);
            lb_ImageName.Text = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
            lb_ImageProperties.Text = $"{Image.FromFile(FilePath).Width}x{Image.FromFile(FilePath).Height} ({new FileInfo(FilePath).Length}b)";
            if (!File.Exists(FilePath)) { return; }
            pb_Thumbnail.SizeMode = PictureBoxSizeMode.Zoom;
            if (FilePath.Split('.')[FilePath.Split('.').Length - 1].Equals("gif"))
            {
                pb_Thumbnail.Image = Image.FromFile(FilePath);
            }
            else { pb_Thumbnail.Image = Image.FromFile(FilePath).GetThumbnailImage(180, 180, null, IntPtr.Zero); }
        }

        public void SelectionClick(object sender, EventArgs e)
        {
            if (((IFileIcon)this).IsSelected) ((IFileIcon)this).Deselected();
            else ((IFileIcon)this).Selected();
        }

        public void Selected()
        {
            ((IFileIcon)this).IsSelected = true;
            panel_MainLayout.BackColor = StyleOptions.GetColor(FilePath, StyleOptions.colorSlot.SelectedColor);
            Owner.SelectFile(this);
        }
        public void Deselected()
        {
            ((IFileIcon)this).IsSelected = false;
            panel_MainLayout.BackColor = StyleOptions.GetColor(FilePath, StyleOptions.colorSlot.EntryColor);
            Owner.DeselectFile(this);
        }
    }
}
