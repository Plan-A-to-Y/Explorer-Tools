using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Explorer_Tools
{
    public partial class form_StandardView : Form
    {

        public TableLayoutPanel BufferPanel;
        public form_StandardView()
        {
            InitializeComponent();
            Metadata.Initialize();
            Folder_Explorer FE = new Folder_Explorer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            sc_Main.Panel1.Controls.Add(FE);
            FE.Dock = DockStyle.Fill;
            FE.Show();
            Folder_Contents FC = new Folder_Contents();
            sc_Main.Panel2.Controls.Add(FC);
            FC.Show();
            FC.DisplayContents(FE.InitialDirectory);
            Metadata.SaveData();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void folderContents_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
