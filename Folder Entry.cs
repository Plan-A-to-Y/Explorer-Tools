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

        ToolTip tt = new ToolTip();

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
            FolderPath = folderPath;
            this.SetTopLevel(false);
            Meta = Metadata.FindFolderData(folderPath);
            InitializeComponent();
            btn_FolderIcon.Image = Image.FromFile(Meta.IconPath);
            rtb_FolderInfo.Hide();
            RefreshVisuals();
        }

        public void GetDesc()
        {
            if (Meta.FolderDesc is null) Meta.FolderDesc = "No Data";
            tb_ThumbText.Lines = Meta.FolderDesc.Split("\n");
        }
        public void GenerateDesc()
        {
            int filecount = 0;
            int dircount = 0;
            double totalsize = 0;
            Queue<string> toSearch = new Queue<string>();
            toSearch.Enqueue(FolderPath);
            while (toSearch.Count > 0)
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
            if (totalsize < 1000) { sizetext = $"{totalsize}b"; }
            else if (totalsize < 1000000) { sizetext = $"{(totalsize / 1000).ToString("##0.00")}kb"; }
            else if (totalsize < 1000000000) { sizetext = $"{(totalsize / 1000000).ToString("##0.00")}mb"; }
            else if (totalsize < 1000000000000) { sizetext = $"{(totalsize / 1000000000).ToString("##0.00")}gb"; }
            Meta.FolderDesc = $"Files: {filecount} Folders: {dircount}\nTotal Size: {sizetext}";
            Meta.ScanDate = DateTime.Now;
            Metadata.UpdateFolderData(Meta);
            tt.RemoveAll();
            RefreshVisuals();
        }

        public void ShowDetails()
        {
            rtb_FolderInfo.Show();
            if (Meta.FolderDetails is null)
            {
                Meta.FolderDetails = "No Description for this Folder exists";
                Metadata.UpdateFolderData(Meta);
            }
            rtb_FolderInfo.Text = Meta.FolderDetails;
        }

        public void HideDetails()
        {
            rtb_FolderInfo.Hide();
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
            if (!Meta.ScanDate.Equals(DateTime.MinValue)) {
                if (Directory.GetLastWriteTime(FolderPath).CompareTo(Meta.ScanDate) > 0) {
                    tt.SetToolTip(tb_ThumbText, "Scan outdated as of at least " + (DateTime.Now - Directory.GetLastWriteTime(FolderPath)).ToString(@"d\dh\hm\m") + " ago");
                    tb_ThumbText.BackColor = Color.Pink;
                }
                else { tb_ThumbText.BackColor = Color.White; }
            }
            GetDesc();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {

        }

        private void btn_Select_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { Owner.SelectFolder(this); }
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            GenerateDesc();
        }

        private void tb_ThumbText_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Expand_Click(object sender, EventArgs e)
        {
            if (ShowDesc) { HideDetails(); ShowDesc = false; btn_Expand.Text = "↓"; }
            else { ShowDetails(); ShowDesc = true; btn_Expand.Text = "↑"; }
        }

        private void rtb_FolderInfo_TextChanged(object sender, EventArgs e)
        {
            Meta.FolderDetails = rtb_FolderInfo.Text;
            Metadata.UpdateFolderData(Meta);
        }
    }
}
