using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

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
            FolderId = Meta.FolderId;
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
        public static bool isGeneratingDesc = false;
        public async void GenerateDesc()
        {
            if (isGeneratingDesc) { MessageBox.Show("Please wait for current scan to finish"); return; }
            isGeneratingDesc = true;
            List<md_Folder> updated = await Task.Run(DescTask);
            foreach(md_Folder md in updated)
            {
                Metadata.UpdateFolderData(md);
            }
            Metadata.SaveData();
            RefreshVisuals();
            isGeneratingDesc = false;
        }
        public async Task<List<md_Folder>> DescTask()
        {
            List<md_Folder> toReturn = new List<md_Folder>();
            int filecount = 0;
            int dircount = 0;
            double totalsize = 0;
            int CurrentDirFiles = 0;
            int CurrentDirSub = 0;
            double CurrentDirSize = 0;
            Queue<string> toSearch = new Queue<string>();
            toSearch.Enqueue(FolderPath);
            while (toSearch.Count > 0)
            {
                string target = toSearch.Dequeue();
                try
                {
                    CurrentDirFiles = 0;
                    CurrentDirSub = 0;
                    CurrentDirSize = 0;
                    foreach (string f in Directory.GetFiles(target))
                    {
                        FileInfo fi = new FileInfo(f);
                        filecount++;
                        CurrentDirFiles++;
                        totalsize += fi.Length;
                        CurrentDirSize += fi.Length;
                    }
                    foreach (string dir in Directory.GetDirectories(target))
                    {
                        dircount++;
                        CurrentDirSub++;
                        toSearch.Enqueue(dir);
                    }
                    md_Folder Md = Metadata.FindFolderData(target);
                    string currentDirSizeText = "";
                    if (CurrentDirSize < 1000) { currentDirSizeText = $"{CurrentDirSize}b"; }
                    else if (CurrentDirSize < 1000000) { currentDirSizeText = $"{(CurrentDirSize / 1000).ToString("##0.00")}kb"; }
                    else if (CurrentDirSize < 1000000000) { currentDirSizeText = $"{(CurrentDirSize / 1000000).ToString("##0.00")}mb"; }
                    else if (CurrentDirSize < 1000000000000) { currentDirSizeText = $"{(CurrentDirSize / 1000000000).ToString("##0.00")}gb"; }
                    Md.FolderDesc = $"Files: {CurrentDirFiles} Folders: {CurrentDirSub}\nTotal Size: {currentDirSizeText}";
                    Md.ScanDate = DateTime.Now;
                    toReturn.Add(Md);
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
            toReturn.Add(Meta);
            return toReturn;
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
            btn_Select.Text = Meta.DisplayName + " ("+FolderId+")";
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
            btn_Select.ForeColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.TextColor);
            btn_Select.FlatAppearance.BorderColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.BorderColor);
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
            else if (e.Button == MouseButtons.Right) { ((Folder_Explorer)Owner).StandardView.OpenFolderView(FolderPath); }
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
