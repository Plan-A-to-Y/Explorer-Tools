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
    public partial class Text_Entry : UserControl, IFileIcon
    {
        public string FilePath { get; set; }
        public int FileId { get; set; }
        public bool IsSelected { get; set; }
        public IDisplayForm Owner { get; set; }
        public Metadata.Types FileType { get; set; }
        public Text_Entry()
        {
            InitializeComponent();
        }
        public Text_Entry(string filePath, IDisplayForm owner)
        {
            Owner = owner;
            if (Metadata.FileMetadata.Find(x => x.FilePath.Equals(FilePath)) != null)
            {
                FileId = Metadata.FileMetadata.Find(x => x.FilePath.Equals(FilePath)).FileId;
            }
            FilePath = filePath;
            InitializeComponent();
        }
        private void TextEntry_Load(object sender, EventArgs e)
        {
            panel_MainLayout.BackColor = StyleOptions.GetColor(FilePath, StyleOptions.colorSlot.EntryColor);
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
