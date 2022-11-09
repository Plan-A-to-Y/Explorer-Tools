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
    public partial class FolderEntry : UserControl, IFolderIcon, StyleWindow
    {
        public md_Folder Meta { get; }
        public bool IsSelected { get; set; }
        public IDisplayForm Owner { get; set; }
        public int FolderId { get; set; }
        public string FolderPath { get; set; }
        public bool ShowDesc { get; set; }
        public List<StyleOptions.ColorSlot> FormColors { get; set; }

        public FolderEntry()
        {
            this.SetTopLevel(false);
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Meta = Metadata.FindFolderData(folderPath);
            FolderId = Meta.FolderId;
            InitializeComponent();
            RefreshVisuals();
        }
        public FolderEntry(string folderPath)
        {
            if (folderPath.Contains("Documents")) ShowDesc = true;
            FolderPath = folderPath;
            this.SetTopLevel(false);
            Meta = Metadata.FindFolderData(folderPath);
            InitializeComponent();
            btn_FolderIcon.Image = Image.FromFile(Meta.IconPath);
            if (ShowDesc)
            {
                rtb_FolderInfo.Show();
                MinimumSize = new Size(MinimumSize.Width, MinimumSize.Height + 100);
                rtb_FolderInfo.Size = new Size(rtb_FolderInfo.Size.Width, 50);
                int filecount = 0;
                int dircount = 0;
                double totalsize = 0;
                Queue<string> toSearch = new Queue<string>();
                toSearch.Enqueue(folderPath);
                while(toSearch.Count > 0)
                {
                    string target = toSearch.Dequeue();
                    try
                    {
                        foreach (string f in Directory.GetFiles(target))
                        {
                            FileInfo fi = new FileInfo(f);
                            filecount++;
                            totalsize += fi.Length;
                        }
                        foreach (string dir in Directory.GetDirectories(target))
                        {
                            dircount++;
                            toSearch.Enqueue(dir);
                        }
                    }
                    catch (Exception e) { }
                }
                string sizetext = "";
                if(totalsize < 1000) { sizetext = $"{totalsize}b"; }
                else if (totalsize < 1000000) { sizetext = $"{(totalsize/ 1000).ToString("##0.00")}kb"; }
                else if (totalsize < 1000000000) { sizetext = $"{(totalsize/ 1000000).ToString("##0.00")}mb"; }
                else if (totalsize < 1000000000000) { sizetext = $"{(totalsize/ 1000000000).ToString("##0.00")}gb"; }
                rtb_FolderInfo.Text = $"Total Files: {filecount}\nTotal Directories: {dircount}\nTotal Size: {sizetext}";
            }
            else
            {
                rtb_FolderInfo.Hide();
                rtb_FolderInfo.Size = new Size(rtb_FolderInfo.Size.Width, 0);
            }
            RefreshVisuals();
        }

        private void btn_SelectFolder_Click(object sender, EventArgs e)
        {
            btn_Select_MouseClick(sender, (MouseEventArgs)e);
        }


        private void FolderEntry_Load(object sender, EventArgs e)
        {
            this.Name = "Folder" + Meta.FolderId;
            btn_Select.Text = Meta.DisplayName;
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

        public void SelectFile(IFileIcon File)
        {
            throw new NotImplementedException();
        }

        public void SelectFolder(IFolderIcon Folder)
        {
            throw new NotImplementedException();
        }

        public void DeselectFile(IFileIcon File)
        {
            throw new NotImplementedException();
        }

        public void DeselectFolder(IFolderIcon Folder)
        {
            throw new NotImplementedException();
        }

        public void RefreshVisuals()
        {
            btn_Select.BackColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.HeaderColor);
            BackColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.EntryColor);
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {

        }

        private void btn_Select_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { Owner.SelectFolder(this); }
        }
    }
}
