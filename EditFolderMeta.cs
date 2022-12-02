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
                RadioButton rb = new RadioButton();
                rb.Text = cs.DisplayName;
                rb.Tag = cs.Slot;
                rb.CheckedChanged += SelectedParamChanged;
                flp_ColorSlots.Controls.Add(rb);
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
            SCString = Active.ColorString;
            label1.Text = SCString;
            UpdateColor();
        }

        private void UpdateColor()
        {
            tb_R.Value = int.Parse(SCString.Split("|")[0]);
            tb_G.Value = int.Parse(SCString.Split("|")[1]);
            tb_B.Value = int.Parse(SCString.Split("|")[2]);
            pn_PreviewColor.BackColor = StyleOptions.ColorFromString(SCString);
            Active.UpdateColor(SCString);
            md.FormColors.Remove(Active);
            md.FormColors.Add(Active);
            Metadata.UpdateFolderData(md);
        }

        private string SelectedColor()
        {
            return $"{tb_R.Value}|{tb_G.Value}|{tb_B.Value}|255";
        }

        private void TB_ValueChanged(object sender, EventArgs e)
        {
            SCString = SelectedColor();
            label1.Text = SCString;
            UpdateColor();
            Owner.Preview.UpdateVisuals();
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            Owner.Preview.UpdateVisuals();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            Metadata.UpdateFolderData(md);
            Metadata.SaveData();
            Init = md;
        }

        private void btn_Revert_Click(object sender, EventArgs e)
        {
            Metadata.UpdateFolderData(Init);
            Setup(Init, Owner);
            MatchColorToFile();
            SCString = $"{tb_R.Value}|{tb_G.Value}|{tb_B.Value}|255";
            Owner.Preview.UpdateVisuals();
        }
    }
}
