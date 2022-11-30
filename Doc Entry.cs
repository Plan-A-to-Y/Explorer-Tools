using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Diagnostics;
using System.Xml.Linq;
using System.Xml;

namespace Explorer_Tools
{
    public partial class Doc_Entry : UserControl, IFileIcon
    {
        public string FilePath { get; set; }
        public IDisplayForm Owner { get; set; }
        public bool IsSelected { get; set; }
        public int FileId { get; set; }
        public Metadata.Types FileType { get; set; }
        public Doc_Entry()
        {
            panel_MainLayout.BackColor = StyleOptions.GetColor(FilePath, StyleOptions.colorSlot.Background);
            InitializeComponent();
            WordprocessingDocument WPD = WordprocessingDocument.Open(FilePath, false);
        }
        public Doc_Entry(string filePath, IDisplayForm owner)
        {
            if (Metadata.FileMetadata.Find(x => x.FilePath.Equals(FilePath)) != null)
            {
                FileId = Metadata.FileMetadata.Find(x => x.FilePath.Equals(FilePath)).FileId;
            }
            Owner = owner;
            FilePath = filePath;
            InitializeComponent();
            WebBrowser wb = new WebBrowser();
            panel_MainLayout.Controls.Add(wb,1,1);
            File.WriteAllText(".\\temp.xml",File.ReadAllText(filePath));
            wb.Navigate(".\\temp.xml");
        }

        public void SelectionClick(object sender, EventArgs e)
        {
            if (((IFileIcon)this).IsSelected) ((IFileIcon)this).Deselected();
            else ((IFileIcon)this).Selected();
        }

        public void Selected()
        {
            ((IFileIcon)this).IsSelected = true;
            panel_MainLayout.BackColor = StyleOptions.GetColor(FilePath, StyleOptions.colorSlot.Highlight);
            Owner.SelectFile(this);
        }
        public void Deselected()
        {
            ((IFileIcon)this).IsSelected = false;
            panel_MainLayout.BackColor = StyleOptions.GetColor(FilePath, StyleOptions.colorSlot.Background);
            Owner.DeselectFile(this);
        }
    }
}
