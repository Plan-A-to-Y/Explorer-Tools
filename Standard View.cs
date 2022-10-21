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

namespace Explorer_Tools
{
    public partial class Form1 : Form
    {
        public List<string> ImageTypes = new List<string>{".bmp",".png",".jpg",".jpeg" };
        public List<string> TextTypes = new List<string> { ".txt" };
        public List<string> DocTypes = new List<string> { ".docx" };
        public Form1()
        {
            InitializeComponent();
            Folder_Explorer FE = new Folder_Explorer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            sc_Main.Panel1.Controls.Add(FE);
            FE.Dock = DockStyle.Fill;
            FE.Show();
            tableLayoutPanel1.RowStyles[0].Height = 200;
            foreach(string file in Directory.GetFiles(FE.InitialDirectory))
            {
                if(ImageTypes.Contains("."+file.Split('.')[file.Split('.').Length - 1]))
                {
                    Image_Entry iEntry = new Image_Entry(file);
                    tableLayoutPanel1.Controls.Add(iEntry);
                    iEntry.Dock = DockStyle.Fill;
                    iEntry.Show();
                    continue;
                }
                if (TextTypes.Contains("." + file.Split('.')[file.Split('.').Length - 1]))
                {
                    Text_Entry iEntry = new Text_Entry(file);
                    tableLayoutPanel1.Controls.Add(iEntry);
                    iEntry.Dock = DockStyle.Fill;
                    iEntry.Show();
                    continue;
                }
                if (DocTypes.Contains("." + file.Split('.')[file.Split('.').Length - 1]))
                {
                    Doc_Entry iEntry = new Doc_Entry(file);
                    tableLayoutPanel1.Controls.Add(iEntry);
                    iEntry.Dock = DockStyle.Fill;
                    iEntry.Show();
                    continue;
                }
                File_Entry fEntry = new File_Entry(file);
                tableLayoutPanel1.Controls.Add(fEntry);
                fEntry.Dock = DockStyle.Fill;
                fEntry.Show();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
        }
    }
}
