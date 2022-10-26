using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Explorer_Tools
{
    public partial class Folder_Contents : Form, IDisplayForm
    {
        md_Folder md;
        string Dir;
        public IFileIcon SelectedFile;
        public List<string> ImageTypes = new List<string> { ".bmp", ".png", ".jpg", ".jpeg", ".gif" };
        public List<string> TextTypes = new List<string> { ".txt" };
        public List<string> DocTypes = new List<string> { ".docx" };

        public Folder_Contents()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        public void DisplayContents(string Path)
        {
            if (Metadata.FolderMetadata.Exists(x => x.FolderPath.Equals(Path))) { md = Metadata.FolderMetadata.Find(x => x.FolderPath.Equals(Path)); }
            else Metadata.FolderMetadata.Add(new md_Folder(Path));
            Dir = Path;
            foreach (string file in Directory.GetFiles(Dir))
            {
                Control iEntry;
                string ext = "." + file.Split('.').Last();
                if (ImageTypes.Contains(ext)) { iEntry = new Image_Entry(file, this); }
                else if (TextTypes.Contains(ext)) { iEntry = new Text_Entry(file, this); }
                else if (DocTypes.Contains(ext)) { iEntry = new Doc_Entry(file, this); }
                else { iEntry = new File_Entry(file, this); }
                panel_Content.Controls.Add(iEntry);
                iEntry.Show();
            }
            panel_Content.Refresh();
        }

        private void folderContents_SizeChanged(object sender, EventArgs e)
        {

        }

        public void SelectFile(IFileIcon fileIco)
        {
            if (SelectedFile != null) { SelectedFile.Deselected(); }
            SelectedFile = fileIco;
        }

        public void SelectFolder(IFolderIcon Folder)
        {
            
        }
        public void DeselectFile(IFileIcon fileIco)
        {
            if (SelectedFile != null) { SelectedFile = null; }
        }

        public void DeselectFolder(IFolderIcon Folder)
        {

        }
    }
}
