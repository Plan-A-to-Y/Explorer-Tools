using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using static Explorer_Tools.StyleOptions;
using System.Windows.Input;
using System.Linq;

namespace Explorer_Tools
{
    public partial class Folder_Explorer : Form, IDisplayForm, IRegisteredColor
    {
        string IDisplayForm.DisplayName { get; set; }
        public string CurrentDirectory { get; set; }
        public form_StandardView StandardView { get; set; }
        public List<IIcon> SelectedItems { get; set; }
        public IView OwningView { get; set; }

        public List<ColorSlot> Palette { get { return Metadata.FindFolderData(CurrentDirectory).FormColors; } set { } }
        public Folder_Explorer()
        {
            CurrentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Init();
        }
        public Folder_Explorer(string Start, IView Owner)
        {
            OwningView = Owner;
            
            CurrentDirectory = Start;
            Init();
        }

        private void Init()
        {
            
            this.SetTopLevel(false);
            InitializeComponent();
            SelectedItems = new List<IIcon>();
            Populate();
            ColorRegistry.RegisterColor(new ColorReg(), this, Metadata.FindFolderData(CurrentDirectory));
            UpdateVisuals();
        }

        private void Populate()
        {
            bool first = true;
            tlp_Content.Controls.Clear();
            tlp_Content.RowCount = 1;
            foreach (string Folder in Directory.GetDirectories(CurrentDirectory))
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
            foreach (string File in Directory.GetFiles(CurrentDirectory))
            {
                File_Entry FEntry = new File_Entry(File, this);
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
            lb_FolderName.Text = CurrentDirectory.Split('\\')[CurrentDirectory.Split('\\').Length - 1];
            md_Folder md = Metadata.FindFolderData(CurrentDirectory);
            if (File.Exists(md.IconPath)) ico_Folder.Image = Image.FromFile(md.IconPath);
            try
            {
                if (!(Directory.GetParent(CurrentDirectory) == null)) btn_GoUp.Show();
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
            CurrentDirectory = Directory.GetParent(CurrentDirectory).FullName;
            Populate();
        }

        public void SelectFile(IFileIcon File)
        {
            SelectItem(File as IIcon);
        }
        public void SelectItem(IIcon ToSelect)
        {
            if (SelectedItems.Contains(ToSelect))
            {
                if (SelectedItems.Count == 1 || ModifierKeys.HasFlag(Keys.Control)) { DeselectItem(ToSelect); return; }
            }
            if (ToSelect is File_Entry)
            {
                if(ModifierKeys.HasFlag(Keys.Control))
                {
                    File_Entry toSelect = ToSelect as File_Entry;
                    OwningView.ActiveDisplayForm = this;
                    //MessageBox.Show("Folder Contents has recieved selection event");
                    toSelect.lb_FileName.BackColor = Highlight(toSelect.lb_FileName.BackColor);
                    ((IDisplayForm)this).SelectedItems.Add(ToSelect);
                }
                else
                {
                    (this as IDisplayForm).DeselectAll(SelectedItems);
                    File_Entry toSelect = ToSelect as File_Entry;
                    OwningView.ActiveDisplayForm = this;
                    //MessageBox.Show("Folder Contents has recieved selection event");
                    toSelect.lb_FileName.BackColor = Highlight(toSelect.lb_FileName.BackColor);
                    ((IDisplayForm)this).SelectedItems.Add(ToSelect);
                }
            }
            if (ToSelect is IFolderIcon)
            {
                IFolderIcon IFI = ToSelect as IFolderIcon;
                CurrentDirectory = IFI.FolderPath;
                Populate();
            }
            if (SelectedItems.Count > 0) lb_Selected.Text = $"{SelectedItems.Count} Items Selected";
            else lb_Selected.Text = "";
            return;
        }

        public void DeselectItem(IIcon ToRemove)
        {
            if (ToRemove is File_Entry)
            {
                File_Entry toDeselect = ToRemove as File_Entry;
                //MessageBox.Show("Folder Contents has recieved Deselection event");
                toDeselect.UpdateVisuals();
                ((IDisplayForm)this).SelectedItems.Remove(ToRemove);
            }
            else MessageBox.Show("Non-fileEntry has been selected");
            if (SelectedItems.Count > 0) lb_Selected.Text = $"{SelectedItems.Count} Items Selected";
            else lb_Selected.Text = "";
        }

        public void SelectFolder(IFolderIcon Folder)
        {
            CurrentDirectory = Folder.FolderPath;
            Populate();
        }

        private void Folder_Explorer_Resize(object sender, EventArgs e)
        {
            
        }

        private void tlp_Content_SizeChanged(object sender, EventArgs e)
        {
            if (tlp_Content.VerticalScroll.Visible) { tlp_Content.Padding = new Padding(0, 0, 0, 0); }
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
            ico_Folder.Image = Image.FromFile(Metadata.FindFolderData(CurrentDirectory).IconPath);
            btn_Close.BackColor = StyleOptions.GetColor(StyleOptions.colorSlot.Primary);
            btn_Close.ForeColor = StyleOptions.GetColor(StyleOptions.colorSlot.TextColor);
            btn_GoUp.BackColor = StyleOptions.GetColor(StyleOptions.colorSlot.Primary);
            btn_GoUp.ForeColor = StyleOptions.GetColor(StyleOptions.colorSlot.TextColor);
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
