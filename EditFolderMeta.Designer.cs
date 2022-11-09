
namespace Explorer_Tools
{
    partial class EditFolderMeta
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
            this.tabs_Main = new System.Windows.Forms.TabControl();
            this.tab_General = new System.Windows.Forms.TabPage();
            this.tab_Colors = new System.Windows.Forms.TabPage();
            this.tlp_Colors = new System.Windows.Forms.TableLayoutPanel();
            this.lb_G = new System.Windows.Forms.Label();
            this.lb_B = new System.Windows.Forms.Label();
            this.tb_R = new System.Windows.Forms.TrackBar();
            this.tb_G = new System.Windows.Forms.TrackBar();
            this.tb_B = new System.Windows.Forms.TrackBar();
            this.pn_PreviewColor = new System.Windows.Forms.Panel();
            this.lb_R = new System.Windows.Forms.Label();
            this.cb_ColorPreset = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Revert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flp_ColorSlots = new System.Windows.Forms.FlowLayoutPanel();
            this.tabs_Main.SuspendLayout();
            this.tab_Colors.SuspendLayout();
            this.tlp_Colors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_B)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs_Main
            // 
            this.tabs_Main.Controls.Add(this.tab_General);
            this.tabs_Main.Controls.Add(this.tab_Colors);
            this.tabs_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs_Main.Location = new System.Drawing.Point(0, 0);
            this.tabs_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tabs_Main.Name = "tabs_Main";
            this.tabs_Main.SelectedIndex = 0;
            this.tabs_Main.Size = new System.Drawing.Size(400, 220);
            this.tabs_Main.TabIndex = 2;
            this.tabs_Main.SelectedIndexChanged += new System.EventHandler(this.tabs_Main_SelectedIndexChanged);
            // 
            // tab_General
            // 
            this.tab_General.BackColor = System.Drawing.Color.DarkGray;
            this.tab_General.Location = new System.Drawing.Point(4, 24);
            this.tab_General.Margin = new System.Windows.Forms.Padding(0);
            this.tab_General.Name = "tab_General";
            this.tab_General.Size = new System.Drawing.Size(392, 192);
            this.tab_General.TabIndex = 0;
            this.tab_General.Text = "General";
            // 
            // tab_Colors
            // 
            this.tab_Colors.BackColor = System.Drawing.Color.DarkGray;
            this.tab_Colors.Controls.Add(this.tlp_Colors);
            this.tab_Colors.Location = new System.Drawing.Point(4, 24);
            this.tab_Colors.Margin = new System.Windows.Forms.Padding(0);
            this.tab_Colors.Name = "tab_Colors";
            this.tab_Colors.Size = new System.Drawing.Size(392, 192);
            this.tab_Colors.TabIndex = 1;
            this.tab_Colors.Text = "Colors";
            // 
            // tlp_Colors
            // 
            this.tlp_Colors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlp_Colors.ColumnCount = 4;
            this.tlp_Colors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Colors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Colors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Colors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp_Colors.Controls.Add(this.lb_G, 1, 2);
            this.tlp_Colors.Controls.Add(this.lb_B, 1, 3);
            this.tlp_Colors.Controls.Add(this.tb_R, 2, 1);
            this.tlp_Colors.Controls.Add(this.tb_G, 2, 2);
            this.tlp_Colors.Controls.Add(this.tb_B, 2, 3);
            this.tlp_Colors.Controls.Add(this.pn_PreviewColor, 3, 2);
            this.tlp_Colors.Controls.Add(this.lb_R, 1, 1);
            this.tlp_Colors.Controls.Add(this.cb_ColorPreset, 2, 0);
            this.tlp_Colors.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.tlp_Colors.Controls.Add(this.flp_ColorSlots, 0, 0);
            this.tlp_Colors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Colors.Location = new System.Drawing.Point(0, 0);
            this.tlp_Colors.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Colors.Name = "tlp_Colors";
            this.tlp_Colors.RowCount = 6;
            this.tlp_Colors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Colors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Colors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Colors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Colors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Colors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Colors.Size = new System.Drawing.Size(392, 192);
            this.tlp_Colors.TabIndex = 0;
            // 
            // lb_G
            // 
            this.lb_G.AutoSize = true;
            this.lb_G.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_G.ForeColor = System.Drawing.Color.Green;
            this.lb_G.Location = new System.Drawing.Point(103, 60);
            this.lb_G.Name = "lb_G";
            this.lb_G.Size = new System.Drawing.Size(24, 30);
            this.lb_G.TabIndex = 11;
            this.lb_G.Text = "G";
            this.lb_G.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_B
            // 
            this.lb_B.AutoSize = true;
            this.lb_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_B.ForeColor = System.Drawing.Color.Blue;
            this.lb_B.Location = new System.Drawing.Point(103, 90);
            this.lb_B.Name = "lb_B";
            this.lb_B.Size = new System.Drawing.Size(24, 30);
            this.lb_B.TabIndex = 10;
            this.lb_B.Text = "B";
            this.lb_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_R
            // 
            this.tb_R.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_R.Location = new System.Drawing.Point(133, 33);
            this.tb_R.Maximum = 255;
            this.tb_R.Name = "tb_R";
            this.tb_R.Size = new System.Drawing.Size(196, 24);
            this.tb_R.TabIndex = 4;
            this.tb_R.Scroll += new System.EventHandler(this.TB_ValueChanged);
            // 
            // tb_G
            // 
            this.tb_G.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_G.Location = new System.Drawing.Point(133, 63);
            this.tb_G.Maximum = 255;
            this.tb_G.Name = "tb_G";
            this.tb_G.Size = new System.Drawing.Size(196, 24);
            this.tb_G.TabIndex = 5;
            this.tb_G.Scroll += new System.EventHandler(this.TB_ValueChanged);
            // 
            // tb_B
            // 
            this.tb_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_B.Location = new System.Drawing.Point(133, 93);
            this.tb_B.Maximum = 255;
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(196, 24);
            this.tb_B.TabIndex = 6;
            this.tb_B.Scroll += new System.EventHandler(this.TB_ValueChanged);
            // 
            // pn_PreviewColor
            // 
            this.pn_PreviewColor.BackColor = System.Drawing.Color.Transparent;
            this.pn_PreviewColor.Location = new System.Drawing.Point(335, 63);
            this.pn_PreviewColor.Name = "pn_PreviewColor";
            this.tlp_Colors.SetRowSpan(this.pn_PreviewColor, 2);
            this.pn_PreviewColor.Size = new System.Drawing.Size(54, 54);
            this.pn_PreviewColor.TabIndex = 7;
            // 
            // lb_R
            // 
            this.lb_R.AutoSize = true;
            this.lb_R.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_R.ForeColor = System.Drawing.Color.Red;
            this.lb_R.Location = new System.Drawing.Point(103, 30);
            this.lb_R.Name = "lb_R";
            this.lb_R.Size = new System.Drawing.Size(24, 30);
            this.lb_R.TabIndex = 9;
            this.lb_R.Text = "R";
            this.lb_R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_ColorPreset
            // 
            this.cb_ColorPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_ColorPreset.FormattingEnabled = true;
            this.cb_ColorPreset.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "White",
            "Black",
            "Gray",
            "Glass (Clear)",
            "Glass (Tinted)"});
            this.cb_ColorPreset.Location = new System.Drawing.Point(133, 3);
            this.cb_ColorPreset.Name = "cb_ColorPreset";
            this.cb_ColorPreset.Size = new System.Drawing.Size(196, 23);
            this.cb_ColorPreset.TabIndex = 13;
            this.cb_ColorPreset.Text = "<Custom>";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tlp_Colors.SetColumnSpan(this.tableLayoutPanel1, 4);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Preview, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Apply, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Revert, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 120);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tlp_Colors.SetRowSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 72);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(235, 45);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(74, 23);
            this.btn_Preview.TabIndex = 1;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(315, 45);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(74, 23);
            this.btn_Apply.TabIndex = 0;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Revert
            // 
            this.btn_Revert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Revert.Location = new System.Drawing.Point(155, 45);
            this.btn_Revert.Name = "btn_Revert";
            this.btn_Revert.Size = new System.Drawing.Size(74, 24);
            this.btn_Revert.TabIndex = 2;
            this.btn_Revert.Text = "Revert";
            this.btn_Revert.UseVisualStyleBackColor = true;
            this.btn_Revert.Click += new System.EventHandler(this.btn_Revert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // flp_ColorSlots
            // 
            this.flp_ColorSlots.AutoScroll = true;
            this.flp_ColorSlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_ColorSlots.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_ColorSlots.Location = new System.Drawing.Point(0, 0);
            this.flp_ColorSlots.Margin = new System.Windows.Forms.Padding(0);
            this.flp_ColorSlots.Name = "flp_ColorSlots";
            this.tlp_Colors.SetRowSpan(this.flp_ColorSlots, 4);
            this.flp_ColorSlots.Size = new System.Drawing.Size(100, 120);
            this.flp_ColorSlots.TabIndex = 15;
            // 
            // EditFolderMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabs_Main);
            this.Name = "EditFolderMeta";
            this.Size = new System.Drawing.Size(400, 220);
            this.tabs_Main.ResumeLayout(false);
            this.tab_Colors.ResumeLayout(false);
            this.tlp_Colors.ResumeLayout(false);
            this.tlp_Colors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_B)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs_Main;
        private System.Windows.Forms.TabPage tab_General;
        private System.Windows.Forms.TabPage tab_Colors;
        private System.Windows.Forms.TableLayoutPanel tlp_Colors;
        private System.Windows.Forms.Label lb_G;
        private System.Windows.Forms.Label lb_B;
        private System.Windows.Forms.TrackBar tb_R;
        private System.Windows.Forms.TrackBar tb_G;
        private System.Windows.Forms.TrackBar tb_B;
        private System.Windows.Forms.Panel pn_PreviewColor;
        private System.Windows.Forms.Label lb_R;
        private System.Windows.Forms.ComboBox cb_ColorPreset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Revert;
        private System.Windows.Forms.FlowLayoutPanel flp_ColorSlots;
        private System.Windows.Forms.Label label1;
    }
}
