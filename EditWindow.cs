using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Explorer_Tools
{
    public partial class EditWindow : Form
    {
        public bool EditFolder;
        public StyleWindow Preview;
        public EditWindow()
        {
            InitializeComponent();
        }

        public void Setup(md_Folder toEdit, StyleWindow preview)
        {
            EditFolderMeta EFM = new EditFolderMeta();
            Controls.Add(EFM);
            Preview = preview;
            EFM.Dock = DockStyle.Fill;
            EFM.Setup(toEdit, this);
            EFM.Show();
        }

        private void EditWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
