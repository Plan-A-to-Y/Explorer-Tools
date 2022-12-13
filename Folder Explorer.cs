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
    public partial class Folder_Explorer : Form, IDisplayForm, IRegisteredColor
    {
        string IDisplayForm.DisplayName { get; set; }
        public string InitialDirectory { get; set; }
        public form_StandardView StandardView { get; set; }
        public List<IIcon> SelectedItems { get; set; }
        public IView OwningView { get; set; }

        public Folder_Explorer()
        {
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Init();
        }
        public Folder_Explorer(string Start, IView Owner)
        {
            OwningView = Owner;
            
            InitialDirectory = Start;
            Init();
        }

        private void Init()
        {
            this.SetTopLevel(false);
            InitializeComponent();
            Populate();
            ColorRegistry.RegisterColor(new ColorReg(), this);
            UpdateVisuals();
        }

        private void Populate()
        {
            bool first = true;
            tlp_Content.Controls.Clear();
            tlp_Content.RowCount = 1;
            foreach (string Folder in Directory.GetDirectories(InitialDirectory))
            {
                FolderEntry FEntry = new FolderEntry(Folder);
                if (!first) tlp_Content.RowCount += 1;
                else
                {
                    first = false;
                    tlp_Content.RowStyles[tlp_Content.RowCount - 1].SizeType = SizeType.AutoSize;
                }
                FEntry.Owner = this;
                tlp_Content.Controls.Add(FEntry);
                FEntry.Dock = DockStyle.Fill;
                FEntry.Show();
            }
            lb_FolderName.Text = InitialDirectory.Split('\\')[InitialDirectory.Split('\\').Length - 1];
            md_Folder md = Metadata.FindFolderData(InitialDirectory);
            if (File.Exists(md.IconPath)) ico_Folder.Image = Image.FromFile(md.IconPath);
            try
            {
                if (!(Directory.GetParent(InitialDirectory) == null)) btn_GoUp.Show();
                else
                {
                    btn_GoUp.Hide(); 
                    lb_FolderName.Text = "Root Directory";
                }
            }
            catch (NullReferenceException e) { btn_GoUp.Hide(); lb_FolderName.Text = "Root Directory"; }
            tlp_Content.RowCount++;
            tlp_Content.RowStyles[tlp_Content.RowStyles.Count - 1].SizeType = SizeType.Percent;
        }

        private void btn_GoUp_Click(object sender, EventArgs e)
        {
            InitialDirectory = Directory.GetParent(InitialDirectory).FullName;
            Populate();
        }

        public void SelectFile(IFileIcon File)
        {
            return;
        }

        public void SelectFolder(IFolderIcon Folder)
        {
            InitialDirectory = Folder.FolderPath;
            Populate();
        }

        private void Folder_Explorer_Resize(object sender, EventArgs e)
        {
            
        }

        private void tlp_Content_SizeChanged(object sender, EventArgs e)
        {
            if (tlp_Content.VerticalScroll.Visible) { tlp_Content.Padding = new Padding(0, 0, 15, 0); }
            else { tlp_Content.Padding = new Padding(0, 0, 0, 0); }
            Refresh();
        }

        public void RemoveFile(IFileIcon File)
        {
            
        }

        public void UpdateVisuals()
        {
            tlp_Content.BackColor = StyleOptions.GetColor(StyleOptions.colorSlot.Background);
            lb_FolderName.ForeColor = StyleOptions.GetColor(StyleOptions.colorSlot.TextColor);
            tlp_Main.BackColor = StyleOptions.GetColor(StyleOptions.colorSlot.Background);
            ico_Folder.Image = Image.FromFile(Metadata.FindFolderData(InitialDirectory).IconPath);
            btn_Close.BackColor = StyleOptions.GetColor(StyleOptions.colorSlot.Primary);
            btn_Close.ForeColor = StyleOptions.GetColor(StyleOptions.colorSlot.TextColor);
            btn_GoUp.BackColor = StyleOptions.GetColor(StyleOptions.colorSlot.Primary);
            btn_GoUp.ForeColor = StyleOptions.GetColor(StyleOptions.colorSlot.TextColor);
        }

        public void SelectItem(IIcon ToSelect)
        {
            return;
        }

        public void DeselectItem(IIcon ToRemove)
        {
            //throw new NotImplementedException();
        }

        public void RemoveItem(IIcon ToRemove)
        {
            //throw new NotImplementedException();
        }

        public void AddItem(IIcon ToRemove)
        {
            //throw new NotImplementedException();
        }
    }
}
