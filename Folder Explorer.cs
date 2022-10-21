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
        public Folder_Explorer(string? Start)
        {
            bool first = true;
            this.SetTopLevel(false);
            if(Start is null) { InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); } else { InitialDirectory = Start; }
            InitializeComponent();
            foreach (string Folder in Directory.GetDirectories(InitialDirectory))
            {
                FolderEntry FEntry = new FolderEntry(Folder);
                if (!first) tableLayoutPanel2.RowCount += 1;
                else
                {
                    first = false;
                    tableLayoutPanel2.RowStyles[tableLayoutPanel2.RowCount-1].SizeType = SizeType.Absolute;
                    tableLayoutPanel2.RowStyles[tableLayoutPanel2.RowCount-1].Height = FEntry.Height;
                }
                
                
                tableLayoutPanel2.Controls.Add(FEntry);
                FEntry.Dock = DockStyle.Fill;
                FEntry.Show();
            }
            lb_FolderName.Text = InitialDirectory.Split('\\')[InitialDirectory.Split('\\').Length - 1];
        }
    }
}
