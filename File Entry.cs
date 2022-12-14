using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using static Explorer_Tools.Metadata;
using System.Diagnostics;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace Explorer_Tools
{
    public partial class File_Entry : UserControl, IFileIcon, IRegisteredColor
    {
        public string FilePath { get; set; }
        public IDisplayForm Owner { get; set; }
        public bool IsSelected { get; set; }
        public int FileId { get; set; }
        public bool ShowDetails { get; set; }
        public Types FileType { get; set; }
        public bool isSelected { get;  set; }
        string IIcon.IcoName { get { return Meta.DisplayName; } set { return; } }

        public md_File Meta;
        public File_Entry()
        {
            InitializeComponent();
        }
        public File_Entry(string filePath, IDisplayForm owner)
        {
            Owner = owner;
            FilePath = filePath;
            InitializeComponent();
            Meta = FindFileData(filePath);
            ColorRegistry.RegisterColor(new ColorReg(), this);
            ((IIcon)this).IcoName = Meta.DisplayName;
            UpdateVisuals();
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {

        }

        private void FileEntry_Load(object sender, EventArgs e)
        {
            if(FileMetadata.Find(x => x.FilePath.Equals(FilePath)) != null)
            {
                FileId = FileMetadata.Find( x => x.FilePath.Equals(FilePath)).FileId;
            }
            tlp_Main.BackColor = StyleOptions.GetColor(FilePath, StyleOptions.colorSlot.Background);
            lb_FileName.Text = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
            if (!File.Exists(FilePath)){ rtb_Details.Text = "FILE DOESN'T EXIST"; return; }
            rtb_Details.Text += $"File Extension: {FilePath.Split('.')[FilePath.Split('.').Length-1]}";
            if (!ShowDetails) tlp_Details.Hide();
            FileType = GetFileType(FilePath);
            pb_Icon.Image = StyleOptions.GetIcon(Metadata.FindFileData(FilePath).IconPath);

            FileInfo fi = new FileInfo(Meta.FilePath);
            long totalsize = fi.Length;
            string sizetext = "";
            if (totalsize < 1000) { sizetext = $"{totalsize}b"; }
            else if (totalsize < 1000000) { sizetext = $"{(totalsize / 1000).ToString("##0.00")}kb"; }
            else if (totalsize < 1000000000) { sizetext = $"{(totalsize / 1000000).ToString("##0.00")}mb"; }
            else if (totalsize < 1000000000000) { sizetext = $"{(totalsize / 1000000000).ToString("##0.00")}gb"; }
            
            if((DateTime.Now - fi.LastWriteTime).TotalDays > .5) 
            {
                btn_DetailList.Text = $"Size: {sizetext}\nModified: {fi.LastWriteTime.ToString(@"mm\\dd\\yy")}"; 
            }
            else
            { 
                btn_DetailList.Text = $"Size: {sizetext}\nModified: {(DateTime.Now - fi.LastWriteTime).ToString(@"h'h 'm'm 's' s'")} ago"; 
            }
            
        }

        private void ClickAndDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { 
                DoDragDrop(this, DragDropEffects.Move);
            }
        }

        bool DoubleClickEvent = false;
        public async void SelectionClick(object sender, EventArgs e)
        {
            if (IsSelected) { Owner.DeselectItem(this); IsSelected = false; }
            else { Owner.SelectItem(this); isSelected = true; }
            await Task.Delay(SystemInformation.DoubleClickTime);
            if(DoubleClickEvent)
            {
                Owner.DeselectItem(this);
                IsSelected = false;
                using Process newproc = new Process();
                newproc.StartInfo.FileName = "explorer";
                newproc.StartInfo.Arguments = "\""+FilePath+"\"";
                newproc.Start();
                DoubleClickEvent = false;
            }
        }


        private void lb_FileName_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickEvent = true;
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            if (!ShowDetails) { tlp_Details.Show(); ShowDetails = true; }
            else if (ShowDetails) { tlp_Details.Hide(); ShowDetails = false; }
        }

        public void UpdateVisuals()
        {
            lb_FileName.ForeColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.TextColor);
            lb_FileName.BackColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.Primary);

            btn_Details.ForeColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.TextColor);
            btn_Details.BackColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.Secondary);

            btn_Interact.ForeColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.TextColor);
            btn_Interact.BackColor = StyleOptions.GetColor(Meta, StyleOptions.colorSlot.Secondary);

            StyleOptions.ApplyColorTags(this);
        }

        private void rtb_Details_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        }
    }
}
