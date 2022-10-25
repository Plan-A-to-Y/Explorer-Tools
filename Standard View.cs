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
        public List<string> ImageTypes = new List<string>{".bmp",".png",".jpg",".jpeg",".gif" };
        public List<string> TextTypes = new List<string> { ".txt" };
        public List<string> DocTypes = new List<string> { ".docx" };
        public TableLayoutPanel BufferPanel;
        public form_StandardView()
        {
            InitializeComponent();
            Folder_Explorer FE = new Folder_Explorer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            sc_Main.Panel1.Controls.Add(FE);
            FE.Dock = DockStyle.Fill;
            FE.Show();
            panel_folderContents.RowStyles[0].Height = 200;
            foreach(string file in Directory.GetFiles(FE.InitialDirectory))
            {
                Control iEntry;
                string ext = "." + file.Split('.').Last();
                if      (ImageTypes.Contains(ext)) { iEntry = new Image_Entry(file); }
                else if (TextTypes.Contains(ext)) { iEntry = new Text_Entry(file); }
                else if (DocTypes.Contains(ext)) { iEntry = new Doc_Entry(file); }
                else    { iEntry = new File_Entry(file); }
                panel_folderContents.Controls.Add(iEntry);
                iEntry.Dock = DockStyle.Fill;
                iEntry.Show();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void folderContents_SizeChanged(object sender, EventArgs e)
        {
            panel_folderContents.SuspendLayout();
            await RebuildGraph();
            panel_folderContents.ResumeLayout();
        }

        private async Task RebuildGraph()
        {
            await Task.Run(() =>
            {
                while((panel_folderContents.Controls.Count / panel_folderContents.ColumnCount) > panel_folderContents.RowCount+1)
                {
                    panel_folderContents.RowCount++;
                }
                while ((panel_folderContents.Controls.Count / panel_folderContents.ColumnCount) < panel_folderContents.RowCount + 1)
                {
                    panel_folderContents.RowCount--;
                }
            }
            );
            return;
        }
    }
}
