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
using System.Globalization;
using System.Collections;
using static Explorer_Tools.StyleOptions;
using static Explorer_Tools.ColorRegistry;

namespace Explorer_Tools
{
    public partial class form_StandardView : Form, IColorPicker, IRegisteredColor, IView
    {
        public TableLayoutPanel BufferPanel;
        public md_Folder Meta;
        bool PreviewEnabled = false;
        public IDisplayForm ActiveDisplayForm { get; set; }
        public List<IDisplayForm> idfs { get { return new List<IDisplayForm>() { ActiveDisplayForm }; } }
        public form_StandardView()
        {
            Metadata.Initialize();
            InitializeComponent();
            ActiveDisplayForm = new Folder_Contents();
            ActiveDisplayForm.DisplayName = "NONE";
            Register(new ColorReg(), this);
            Folder_Explorer FE = new Folder_Explorer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), this);
            tp_Explorer.Controls.Add(FE);
            FE.StandardView = this;
            FE.Dock = DockStyle.Fill;
            FE.Show();
            btn_ShowSidebar.Hide();
            tlp_AppearanceContext.Hide();
            tabs_Sidebar.SelectedIndex = 1;
            Types = Enum.GetNames(typeof(Metadata.Types)).ToList();
            ActiveSet = Metadata.DefaultColors;
            UpdatePreview();
            foreach (DictionaryEntry i in Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, false, true))
            {
                cb_Icons.Items.Add(i.Key);
            }
            tabs_Sidebar.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabs_Sidebar.DrawItem += AltDrawItem;

            UpdateVisuals();
            cs_P.lb_Header.Text = "Primary";
            cs_P.SetValue(StyleOptions.GetColor(StyleOptions.colorSlot.Primary));
            cs_S.lb_Header.Text = "Secondary";
            cs_S.SetValue(StyleOptions.GetColor(StyleOptions.colorSlot.Secondary));
            cs_T.lb_Header.Text = "Tertiary";
            cs_T.SetValue(StyleOptions.GetColor(StyleOptions.colorSlot.Tertiary));
            cs_B.lb_Header.Text = "Background";
            cs_B.SetValue(StyleOptions.GetColor(StyleOptions.colorSlot.Background));
            cs_F.lb_Header.Text = "Text";
            cs_F.SetValue(StyleOptions.GetColor(StyleOptions.colorSlot.TextColor));

            cs_P.ValueUpdateEvent += ColorUpdated;
            cs_S.ValueUpdateEvent += ColorUpdated;
            cs_T.ValueUpdateEvent += ColorUpdated;
            cs_B.ValueUpdateEvent += ColorUpdated;
            cs_F.ValueUpdateEvent += ColorUpdated;
            listBox1.DataSource = GlobalData.CopyBuffer;
            listBox1.DisplayMember = "IcoName";
            listBox2.DataSource = idfs;
            listBox2.DisplayMember = "DisplayName";
        }

        private void ColorUpdated(object sender, EventArgs e)
        {
            if(((ColorSlider)sender).lb_Header.Text.Equals("Primary"))
            {
                pn_ColorP.BackColor = ((ColorSlider)sender).CurrentColor;
            }
            if (((ColorSlider)sender).lb_Header.Text.Equals("Secondary"))
            {
                pn_ColorS.BackColor = ((ColorSlider)sender).CurrentColor;
            }
            if (((ColorSlider)sender).lb_Header.Text.Equals("Tertiary"))
            {
                pn_ColorT.BackColor = ((ColorSlider)sender).CurrentColor;
            }
            if (((ColorSlider)sender).lb_Header.Text.Equals("Background"))
            {
                pn_ColorB.BackColor = ((ColorSlider)sender).CurrentColor;
            }
            if (((ColorSlider)sender).lb_Header.Text.Equals("Text"))
            {
                pn_ColorF.BackColor = ((ColorSlider)sender).CurrentColor;
            }
        }

        public void UpdateVisuals()
        {
            ApplyColorTags(this, Metadata.DefaultColors);
            Refresh();
            PreviewEnabled = false;
        }

        private void AltDrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            TabControl tc = sender as TabControl;
            Color col = StyleOptions.GetColor(StyleOptions.colorSlot.Background);
            if (tc.Tag is null) return;
            switch (tc.Tag.ToString())
            {
                case string a when a.Contains("TabHeader:P"):
                    if (PreviewEnabled) col = pn_ColorP.BackColor;
                    else col = StyleOptions.GetColor(StyleOptions.colorSlot.Primary);
                    break;
                case string a when a.Contains("TabHeader:S"):
                    if (PreviewEnabled) col = pn_ColorS.BackColor;
                    else col = StyleOptions.GetColor(StyleOptions.colorSlot.Secondary);
                    break;
                case string a when a.Contains("TabHeader:T"):
                    if (PreviewEnabled) col = pn_ColorT.BackColor;
                    else col = StyleOptions.GetColor(StyleOptions.colorSlot.Tertiary);
                    break;
                case string a when a.Contains("TabHeader:B"):
                    if (PreviewEnabled) col = pn_ColorB.BackColor;
                    else col = StyleOptions.GetColor(StyleOptions.colorSlot.Background);
                    break;
                case string a when a.Contains("TabHeader:F"):
                    if (PreviewEnabled) col = pn_ColorF.BackColor;
                    else col = StyleOptions.GetColor(StyleOptions.colorSlot.TextColor);
                    break;
            }
            using (Brush br = new SolidBrush(col))
            {
                // Color the Tab Header
                e.Graphics.FillRectangle(br, e.Bounds);
                // swap our height and width dimensions
                var rotatedRectangle = new Rectangle(0, 0, e.Bounds.Height, e.Bounds.Width);

                // Rotate
                e.Graphics.ResetTransform();
                e.Graphics.RotateTransform(-90);

                // Translate to move the rectangle to the correct position.
                e.Graphics.TranslateTransform(e.Bounds.Left, e.Bounds.Bottom, System.Drawing.Drawing2D.MatrixOrder.Append);

                // Format String
                var drawFormat = new System.Drawing.StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };


                // Draw Header Text
                if (PreviewEnabled) e.Graphics.DrawString(tc.TabPages[e.Index].Text, e.Font, new SolidBrush(pn_ColorF.BackColor), rotatedRectangle, drawFormat);
                else e.Graphics.DrawString(tc.TabPages[e.Index].Text, e.Font, new SolidBrush(StyleOptions.GetColor(StyleOptions.colorSlot.TextColor)), rotatedRectangle, drawFormat);
            }
        }

        public void Register(ColorReg colorReg, IRegisteredColor self)
        {

        }

        public void OpenFolderView(string path)
        {
            Folder_Contents FC = new Folder_Contents();
            FC.OwningView = this;
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
                        cb_CategoryTag.DataSource = Enum.GetValues(typeof(Metadata.Types));
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
            pn_ColorP.BackColor = (from x in ActiveSet where x.Slot.Equals(StyleOptions.colorSlot.Primary) select x).First().Color;
            pn_ColorS.BackColor = (from x in ActiveSet where x.Slot.Equals(StyleOptions.colorSlot.Secondary) select x).First().Color;
            pn_ColorT.BackColor = (from x in ActiveSet where x.Slot.Equals(StyleOptions.colorSlot.Tertiary) select x).First().Color;
            pn_ColorF.BackColor = (from x in ActiveSet where x.Slot.Equals(StyleOptions.colorSlot.TextColor) select x).First().Color;
            pn_ColorB.BackColor = (from x in ActiveSet where x.Slot.Equals(StyleOptions.colorSlot.Background) select x).First().Color;
        }

        private void cb_Icons_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pb_IconPreview.Image = (Image)Properties.Resources.ResourceManager.GetObject(cb_Icons.SelectedItem.ToString());
            if(CurrentMode == AppearanceMode.Category)
            {
                Metadata.Types type = (Metadata.Types)cb_CategoryTag.SelectedItem;
                switch(type)
                {
                    case Metadata.Types.File:
                        Metadata.DefaultIcon_File = $".\\Icons\\{cb_Icons.SelectedText}.png";
                        break;
                    case Metadata.Types.Folder:
                        Metadata.DefaultIcon_Folder = $".\\Icons\\{cb_Icons.SelectedText}.png";
                        break;
                    case Metadata.Types.Image:
                        Metadata.DefaultIcon_Image = $".\\Icons\\{cb_Icons.SelectedText}.png";
                        break;
                    case Metadata.Types.Text:
                        Metadata.DefaultIcon_Text = $".\\Icons\\{cb_Icons.SelectedText}.png";
                        break;
                }
            }
        }

        private void cb_Preview_CheckedChanged(object sender, EventArgs e)
        {
            PreviewEnabled = cb_Preview.Checked;
            UpdateVisuals();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            if (CurrentMode == AppearanceMode.Defaults)
            {
                Metadata.UpdateDefaultColors(pn_ColorP.BackColor, colorSlot.Primary);
                Metadata.UpdateDefaultColors(pn_ColorS.BackColor, colorSlot.Secondary);
                Metadata.UpdateDefaultColors(pn_ColorT.BackColor, colorSlot.Tertiary);
                Metadata.UpdateDefaultColors(pn_ColorB.BackColor, colorSlot.Background);
                Metadata.UpdateDefaultColors(pn_ColorF.BackColor, colorSlot.TextColor);
            }
            Metadata.SaveData();
            ColorRegistry.RefreshCategory(ColorRegType.Default);
            ActiveSet = Metadata.DefaultColors;
            UpdateVisuals();
        }

        private void form_StandardView_KeyDown(object sender, KeyEventArgs e)
        {
            if (ActiveDisplayForm == null) return;
            
            if (e.Control && e.KeyCode == Keys.C)
            {
                ActiveDisplayForm.Copy();
                MessageBox.Show($"Copied {GlobalData.CopyBuffer.Count} items to the clipboard.");
                listBox1.Update();
                listBox2.Update();
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                listBox2.Update();
                ActiveDisplayForm.Paste();
            }
            else if (e.Control)
            {
                
            }
        }
    }
}
