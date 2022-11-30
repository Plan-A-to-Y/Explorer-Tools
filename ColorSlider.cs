using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Explorer_Tools
{
    public partial class ColorSlider : UserControl
    {
        public Color CurrentColor = Color.White;
        public EventHandler onValueUpdated;
        public ColorSlider()
        {
            this.Load += ColorSlider_Load;
            InitializeComponent();
            tb_R.ValueChanged += TB_ValueUpdated;
            tb_B.ValueChanged += TB_ValueUpdated;
            tb_G.ValueChanged += TB_ValueUpdated;

            nud_R.ValueChanged += NUD_ValueUpdated;
            nud_G.ValueChanged += NUD_ValueUpdated;
            nud_B.ValueChanged += NUD_ValueUpdated;
        }

        private void ColorSlider_Load(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {

            }
        }

        public void SetValue(Color NewValue)
        {
            nud_R.Value =  NewValue.R;
            tb_R.Value = NewValue.R;
            nud_G.Value =  NewValue.G;
            tb_G.Value = NewValue.G;
            nud_B.Value = NewValue.B;
            tb_B.Value = NewValue.B;

            ValueUpdated(NewValue);
        }

        public void ValueUpdated(Color NewColor)
        {
            pn_ColorPreview.BackColor = NewColor;
            CurrentColor = NewColor;
            EventArgs e = new EventArgs();
            onValueUpdated?.Invoke(this, e);
        }

        public event EventHandler ValueUpdateEvent
        {
            add
            {
                onValueUpdated += value;
            }
            remove
            {
                onValueUpdated -= value;
            }
        }

        public void TB_ValueUpdated(object sender, EventArgs e)
        {
            nud_R.Value = tb_R.Value;
            nud_G.Value = tb_G.Value;
            nud_B.Value = tb_B.Value;
            ValueUpdated(Color.FromArgb(tb_R.Value, tb_G.Value, tb_B.Value));
        }
        public void NUD_ValueUpdated(object sender, EventArgs e)
        {
            tb_R.Value = int.Parse(nud_R.Value.ToString());
            tb_G.Value = int.Parse(nud_G.Value.ToString());
            tb_B.Value = int.Parse(nud_B.Value.ToString());
            ValueUpdated(Color.FromArgb(tb_R.Value, tb_G.Value, tb_B.Value));
        }
    }
}
