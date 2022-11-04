using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Explorer_Tools.StyleOptions;

namespace Explorer_Tools
{
    public enum ToColor
    {
        Header,
        Main,
        Border,
        BorderCorner
    }
    public partial class EditFolderMeta : UserControl
    {
        public EditWindow Owner;
        public md_Folder md;
        public ToColor TC;
        public string SCString;
        public string prev;
        public md_Folder Init;
        public string Header;
        public string Main;
        public string Border;
        public string BorderCorner;
        public EditFolderMeta()
        {
            InitializeComponent();
        }
        public void Setup(md_Folder meta, EditWindow owner)
        {
            md = meta;
            Init = meta;
            Owner = owner;

            Header = StringFromColor(GetColor(md, colorSlot.HeaderColor));
            Main = StringFromColor(GetColor(md, colorSlot.EntryColor));
            Border = StringFromColor(GetColor(md, colorSlot.BorderColor));
            BorderCorner = StringFromColor(GetColor(md, colorSlot.BorderCornerColor));
            Owner.Preview.RefreshVisuals();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabs_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabs_Main.SelectedIndex == 1) rb_Header.Checked = true;
            MatchColorToFile();
        }

        private void SelectedParamChanged(object sender, EventArgs e)
        {
            MatchColorToFile();   
        }

        private void MatchColorToFile()
        {
            SCString = SelectedColor();
            UpdateColor();
        }

        private void UpdateColor()
        {
            tb_R.Value = int.Parse(SCString.Split("|")[0]);
            tb_G.Value = int.Parse(SCString.Split("|")[1]);
            tb_B.Value = int.Parse(SCString.Split("|")[2]);
            pn_PreviewColor.BackColor = StyleOptions.ColorFromString(SCString);
        }

        private string SelectedColor()
        {
            if (rb_Header.Checked){ TC = ToColor.Header; return Header; }
            else if (rb_Main.Checked){ TC = ToColor.Main; return Main; }
            else if (rb_Border.Checked){ TC = ToColor.Border; return Border; }
            else if (rb_BorderCorner.Checked) { TC = ToColor.BorderCorner; return BorderCorner; }
            return "0|0|0|255";
        }

        private void TB_ValueChanged(object sender, EventArgs e)
        {
            SCString = $"{tb_R.Value}|{tb_G.Value}|{tb_B.Value}|255";
            switch (TC)
            {
                case ToColor.Header:
                    Header = SCString;
                    break;
                case ToColor.Main:
                    Main = SCString;
                    break;
                case ToColor.Border:
                    Border = SCString;
                    break;
                case ToColor.BorderCorner:
                    BorderCorner = SCString;
                    break;
            }
            UpdateColor();
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            List<StyleOptions.ColorSlot> Overrides = md.FormColors;
            Overrides.RemoveAll(x => x.Slot == StyleOptions.colorSlot.HeaderColor);
            Overrides.RemoveAll(x => x.Slot == StyleOptions.colorSlot.EntryColor);
            Overrides.RemoveAll(x => x.Slot == StyleOptions.colorSlot.BorderColor);
            Overrides.RemoveAll(x => x.Slot == StyleOptions.colorSlot.BorderCornerColor);
            Overrides.AddRange(
                new List<ColorSlot>
                {
                    new StyleOptions.ColorSlot(StyleOptions.colorSlot.HeaderColor, Header),
                    new StyleOptions.ColorSlot(StyleOptions.colorSlot.EntryColor, Main),
                    new StyleOptions.ColorSlot(StyleOptions.colorSlot.BorderColor, Border),
                    new StyleOptions.ColorSlot(StyleOptions.colorSlot.BorderCornerColor, BorderCorner),
                }
            );
            md.FormColors = Overrides;
            Metadata.UpdateFolderData(md);
            Owner.Preview.RefreshVisuals();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            Metadata.SaveData();
        }

        private void btn_Revert_Click(object sender, EventArgs e)
        {
            Metadata.UpdateFolderData(Init);
            Setup(Init, Owner);
            MatchColorToFile();
            SCString = $"{tb_R.Value}|{tb_G.Value}|{tb_B.Value}|255";
            switch (TC)
            {
                case ToColor.Header:
                    Header = SCString;
                    break;
                case ToColor.Main:
                    Main = SCString;
                    break;
                case ToColor.Border:
                    Border = SCString;
                    break;
                case ToColor.BorderCorner:
                    BorderCorner = SCString;
                    break;
            }
            Owner.Preview.RefreshVisuals();
        }
    }
}
