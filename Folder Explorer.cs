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
            if(Start is null) { InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); } else { InitialDirectory = Start; }
            InitializeComponent();
            foreach (string Folder in Directory.GetDirectories(InitialDirectory))
            {
                ContentPanel.Controls.Add(new FolderEntry(Folder));
            }
        }
    }
}
