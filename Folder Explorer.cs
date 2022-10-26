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
    public partial class Folder_Explorer : Form
    {
        public string InitialDirectory { get; }
        public Folder_Explorer()
        {
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Init();
        }
        public Folder_Explorer(string Start)
        {
            InitialDirectory = Start;
            Init();
        }

        private void Init()
        {
            bool first = true;
            this.SetTopLevel(false);
            InitializeComponent();
            foreach (string Folder in Directory.GetDirectories(InitialDirectory))
            {
                FolderEntry FEntry = new FolderEntry(Folder);
                if (!first) tableLayoutPanel2.RowCount += 1;
                else
                {
                    first = false;
                    tableLayoutPanel2.RowStyles[tableLayoutPanel2.RowCount - 1].SizeType = SizeType.Absolute;
                    tableLayoutPanel2.RowStyles[tableLayoutPanel2.RowCount - 1].Height = FEntry.Height;
                }


                tableLayoutPanel2.Controls.Add(FEntry);
                FEntry.Dock = DockStyle.Fill;
                FEntry.Show();
            }
            lb_FolderName.Text = InitialDirectory.Split('\\')[InitialDirectory.Split('\\').Length - 1];
            md_Folder md = Metadata.FolderMetadata.Find(x => x.FolderPath.Equals(InitialDirectory));
            if (File.Exists(md.IconPath)) ico_Folder.Image = Image.FromFile(md.IconPath);
        }
    }
}
