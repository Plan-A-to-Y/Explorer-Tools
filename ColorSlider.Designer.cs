
namespace Explorer_Tools
{
    partial class ColorSlider
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pn_ColorPreview = new System.Windows.Forms.Panel();
            this.tlp_Sliders = new System.Windows.Forms.TableLayoutPanel();
            this.tb_G = new System.Windows.Forms.TrackBar();
            this.tb_R = new System.Windows.Forms.TrackBar();
            this.nud_B = new System.Windows.Forms.NumericUpDown();
            this.nud_G = new System.Windows.Forms.NumericUpDown();
            this.nud_R = new System.Windows.Forms.NumericUpDown();
            this.tb_B = new System.Windows.Forms.TrackBar();
            this.lb_Header = new System.Windows.Forms.Label();
            this.tlp_Main.SuspendLayout();
            this.tlp_Sliders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_B)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 2;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Main.Controls.Add(this.btn_Reset, 1, 2);
            this.tlp_Main.Controls.Add(this.pn_ColorPreview, 1, 1);
            this.tlp_Main.Controls.Add(this.tlp_Sliders, 0, 1);
            this.tlp_Main.Controls.Add(this.lb_Header, 0, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 3;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.Size = new System.Drawing.Size(276, 140);
            this.tlp_Main.TabIndex = 0;
            this.tlp_Main.Tag = "Back:B";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(236, 63);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Reset.MinimumSize = new System.Drawing.Size(40, 40);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(40, 77);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Tag = "Fore:F Back:S BtnBorder:T";
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            // 
            // pn_ColorPreview
            // 
            this.pn_ColorPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ColorPreview.Location = new System.Drawing.Point(239, 18);
            this.pn_ColorPreview.Name = "pn_ColorPreview";
            this.pn_ColorPreview.Size = new System.Drawing.Size(34, 42);
            this.pn_ColorPreview.TabIndex = 0;
            // 
            // tlp_Sliders
            // 
            this.tlp_Sliders.ColumnCount = 2;
            this.tlp_Sliders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Sliders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Sliders.Controls.Add(this.tb_G, 0, 1);
            this.tlp_Sliders.Controls.Add(this.tb_R, 0, 0);
            this.tlp_Sliders.Controls.Add(this.nud_B, 1, 2);
            this.tlp_Sliders.Controls.Add(this.nud_G, 1, 1);
            this.tlp_Sliders.Controls.Add(this.nud_R, 1, 0);
            this.tlp_Sliders.Controls.Add(this.tb_B, 0, 2);
            this.tlp_Sliders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Sliders.Location = new System.Drawing.Point(0, 15);
            this.tlp_Sliders.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Sliders.Name = "tlp_Sliders";
            this.tlp_Sliders.RowCount = 3;
            this.tlp_Main.SetRowSpan(this.tlp_Sliders, 2);
            this.tlp_Sliders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlp_Sliders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_Sliders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_Sliders.Size = new System.Drawing.Size(236, 125);
            this.tlp_Sliders.TabIndex = 2;
            this.tlp_Sliders.Tag = "Back:B";
            // 
            // tb_G
            // 
            this.tb_G.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_G.Location = new System.Drawing.Point(3, 44);
            this.tb_G.Maximum = 255;
            this.tb_G.Name = "tb_G";
            this.tb_G.Size = new System.Drawing.Size(190, 35);
            this.tb_G.TabIndex = 5;
            // 
            // tb_R
            // 
            this.tb_R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_R.Location = new System.Drawing.Point(3, 3);
            this.tb_R.Maximum = 255;
            this.tb_R.Name = "tb_R";
            this.tb_R.Size = new System.Drawing.Size(190, 35);
            this.tb_R.TabIndex = 4;
            // 
            // nud_B
            // 
            this.nud_B.AutoSize = true;
            this.nud_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_B.Location = new System.Drawing.Point(196, 82);
            this.nud_B.Margin = new System.Windows.Forms.Padding(0);
            this.nud_B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_B.Name = "nud_B";
            this.nud_B.Size = new System.Drawing.Size(40, 23);
            this.nud_B.TabIndex = 2;
            this.nud_B.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // nud_G
            // 
            this.nud_G.AutoSize = true;
            this.nud_G.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_G.Location = new System.Drawing.Point(196, 41);
            this.nud_G.Margin = new System.Windows.Forms.Padding(0);
            this.nud_G.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_G.Name = "nud_G";
            this.nud_G.Size = new System.Drawing.Size(40, 23);
            this.nud_G.TabIndex = 1;
            this.nud_G.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // nud_R
            // 
            this.nud_R.AutoSize = true;
            this.nud_R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_R.Location = new System.Drawing.Point(196, 0);
            this.nud_R.Margin = new System.Windows.Forms.Padding(0);
            this.nud_R.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_R.Name = "nud_R";
            this.nud_R.Size = new System.Drawing.Size(40, 23);
            this.nud_R.TabIndex = 0;
            this.nud_R.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // tb_B
            // 
            this.tb_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_B.Location = new System.Drawing.Point(3, 85);
            this.tb_B.Maximum = 255;
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(190, 37);
            this.tb_B.TabIndex = 3;
            // 
            // lb_Header
            // 
            this.lb_Header.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lb_Header.AutoSize = true;
            this.tlp_Main.SetColumnSpan(this.lb_Header, 2);
            this.lb_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Header.Location = new System.Drawing.Point(3, 0);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(270, 15);
            this.lb_Header.TabIndex = 3;
            this.lb_Header.Tag = "Fore:F Back:T";
            this.lb_Header.Text = "COLORSLIDER LABEL";
            this.lb_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Main);
            this.Name = "ColorSlider";
            this.Size = new System.Drawing.Size(276, 140);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            this.tlp_Sliders.ResumeLayout(false);
            this.tlp_Sliders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_B)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.Panel pn_ColorPreview;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TableLayoutPanel tlp_Sliders;
        private System.Windows.Forms.TrackBar tb_G;
        private System.Windows.Forms.TrackBar tb_R;
        private System.Windows.Forms.NumericUpDown nud_B;
        private System.Windows.Forms.NumericUpDown nud_G;
        private System.Windows.Forms.NumericUpDown nud_R;
        private System.Windows.Forms.TrackBar tb_B;
        public System.Windows.Forms.Label lb_Header;
    }
}
