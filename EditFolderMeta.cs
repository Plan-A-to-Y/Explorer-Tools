using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Explorer_Tools.ColorRegistry;
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
        public ColorSlot Active;
        public EditFolderMeta()
        {
            InitializeComponent();
        }
        public void Setup(md_Folder meta, EditWindow owner)
        {
            md = meta;
            Init = meta;
            Owner = owner;
            flp_ColorSlots.Controls.Clear();
            foreach(StyleOptions.ColorSlot cs in md.FormColors)
            {
                if(cs.DisplayName is null) { continue; }
                RadioButton rb = new RadioButton();
                rb.Text = cs.DisplayName;
                rb.Tag = cs.Slot;
                rb.CheckedChanged += SelectedParamChanged;
                flp_ColorSlots.Controls.Add(rb);
            }
            foreach (KnownColor kc in Enum.GetValues(typeof(KnownColor)))
            {
                cb_ColorPreset.Items.Add(kc.ToString());
            }
            SCString = "0|0|0|255";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabs_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabs_Main.SelectedIndex == 1) (flp_ColorSlots.Controls[0] as RadioButton).Checked = true;
            MatchColorToFile();
        }

        private void SelectedParamChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in flp_ColorSlots.Controls)
            {
                if(r.Checked) Active = md.FormColors.Find(x => x.DisplayName.Equals(r.Text));
            }
            MatchColorToFile();   
        }

        private void MatchColorToFile()
        {
            SCString = StringFromColor(GetColor(md, Active.Slot));
            UpdateColor();
        }

        private void UpdateColor()
        {
            tb_R.Value = StyleOptions.ColorFromString(SCString).R;
            tb_G.Value = StyleOptions.ColorFromString(SCString).G;
            tb_B.Value = StyleOptions.ColorFromString(SCString).B;
            pn_PreviewColor.BackColor = StyleOptions.ColorFromString(SCString);
            Active.UpdateColor(SCString);
            md.FormColors.Remove(Active);
            md.FormColors.Add(Active);
            Metadata.UpdateFolderData(md);
            Owner.Preview.UpdateVisuals();
        }

        private string SelectedColor()
        {
            return $"{tb_R.Value}|{tb_G.Value}|{tb_B.Value}|255";
        }

        private void TB_ValueChanged(object sender, EventArgs e)
        {
            SCString = SelectedColor();
            UpdateColor();
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            Owner.Preview.UpdateVisuals();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            foreach( RCEntry r in (from c in ColorRegistry.RegisteredColors where c is RCEntry_Folder && (c as RCEntry_Folder).FolderPath.Equals(md.FolderPath) select c))
            {
                r.CR.RegType = ColorRegType.Custom;
            }
            Metadata.UpdateFolderData(md);
            Metadata.SaveData();
            Init = md;
            ColorRegistry.RefreshCategory(ColorRegType.Custom);
        }

        private void btn_Revert_Click(object sender, EventArgs e)
        {
            Metadata.UpdateFolderData(Init);
            Setup(Init, Owner);
            MatchColorToFile();
            SCString = $"{tb_R.Value}|{tb_G.Value}|{tb_B.Value}|255";
            Owner.Preview.UpdateVisuals();
        }

        private void cb_ColorPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color newcol = Color.FromKnownColor(Enum.Parse<KnownColor>(cb_ColorPreset.SelectedItem.ToString()));
            SCString = $"{newcol.R}|{newcol.G}|{newcol.B}|255";
            UpdateColor();
        }
    }
}
