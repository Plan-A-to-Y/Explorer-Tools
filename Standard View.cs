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
    public partial class form_StandardView : Form, IColorPicker
    {
        public TableLayoutPanel BufferPanel;
        public md_Folder Meta;
        public form_StandardView()
        {
            InitializeComponent();
            Metadata.Initialize();
            Folder_Explorer FE = new Folder_Explorer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            tp_Explorer.Controls.Add(FE);
            FE.StandardView = this;
            FE.Dock = DockStyle.Fill;
            FE.Show();
            OpenFolderView(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            Metadata.SaveData();
            btn_ShowSidebar.Hide();
            tlp_AppearanceContext.Hide();
            tabs_Sidebar.SelectedIndex = 1;
            Types = Enum.GetNames(typeof(Metadata.Types)).ToList();
            ActiveSet = StyleOptions.DefaultColors;
            UpdatePreview();
        }

        public void OpenFolderView(string path)
        {
            Folder_Contents FC = new Folder_Contents();
            pn_Main.Controls.Add(FC);
            FC.Show();
            FC.DisplayContents(path);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void folderContents_SizeChanged(object sender, EventArgs e)
        {

        }
        private void tabs_Sidebar_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(e.TabPageIndex == 0) 
            {  
                tabs_Sidebar.Hide();
                e.Cancel = true;
                btn_ShowSidebar.Show();
            }
        }

        private void btn_ShowSidebar_Click(object sender, EventArgs e)
        {
            tabs_Sidebar.Show();
            btn_ShowSidebar.Hide();
        }

        public enum AppearanceMode
        {
            Defaults,
            Category,
            Tag,
            Presets
        }
        public AppearanceMode CurrentMode = AppearanceMode.Defaults;
        private void rb_Defaults_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = AppearanceMode.Defaults;
            UpdateAppearanceMode();
        }

        private void rb_Category_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = AppearanceMode.Category;
            UpdateAppearanceMode();
        }

        private void rb_Tag_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = AppearanceMode.Tag;
            UpdateAppearanceMode();
        }
        private void rb_Presets_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = AppearanceMode.Presets;
            UpdateAppearanceMode();
        }

        public List<string> Types;
        public StyleOptions.colorSlot ActiveColorSlot;
        public List<StyleOptions.ColorSlot> ActiveSet;
        private void UpdateAppearanceMode()
        {
            switch(CurrentMode)
            {
                case AppearanceMode.Defaults:
                    {
                        tlp_AppearanceContext.Hide();
                        break;
                    }
                case AppearanceMode.Category:
                    {
                        tlp_AppearanceContext.Show();
                        lb_AppearanceContext.Text = "Category:";
                        cb_CategoryTag.DisplayMember = "";
                        cb_CategoryTag.DataSource = Types;
                        cb_CategoryTag.SelectedIndex = 0;
                        break;
                    }
                case AppearanceMode.Tag:
                    {
                        tlp_AppearanceContext.Show();
                        lb_AppearanceContext.Text = "Tag:";
                        cb_CategoryTag.DisplayMember = "Name";
                        cb_CategoryTag.DataSource = Metadata.Tags;
                        cb_CategoryTag.Refresh();
                        break;
                    }
                case AppearanceMode.Presets:
                    {
                        tlp_AppearanceContext.Show();
                        lb_AppearanceContext.Text = "Presets:";
                        break;
                    }
                default: { break; }
            }
        }

        public void UpdateColor(Color newColor)
        {

        }
        public void UpdatePreview()
        {
            pn_ColorHeader.BackColor = StyleOptions.ColorFromString((from x in ActiveSet where x.Slot.Equals(StyleOptions.colorSlot.HeaderColor) select x).First().Color);
            pn_ColorConent.BackColor = StyleOptions.ColorFromString((from x in ActiveSet where x.Slot.Equals(StyleOptions.colorSlot.EntryColor) select x).First().Color);
            pn_ColorAccent.BackColor = StyleOptions.ColorFromString((from x in ActiveSet where x.Slot.Equals(StyleOptions.colorSlot.BorderColor) select x).First().Color);
            pn_ColorText.BackColor = StyleOptions.ColorFromString((from x in ActiveSet where x.Slot.Equals(StyleOptions.colorSlot.TextColor) select x).First().Color);
        }


    }
}
