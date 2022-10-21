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

namespace Explorer_Tools
{
    public partial class Doc_Entry : UserControl
    {
        public string FilePath;
        public Doc_Entry()
        {
            InitializeComponent();
            WordprocessingDocument WPD = WordprocessingDocument.Open(FilePath, false);
            rtb_Content.Text = WPD.MainDocumentPart.Document.InnerText;
        }
        public Doc_Entry(string filePath)
        {
            FilePath = filePath;
            InitializeComponent();
            WordprocessingDocument WPD = WordprocessingDocument.Open(FilePath, false);
            rtb_Content.Text = WPD.MainDocumentPart.Document.InnerText;
        }
    }
}
