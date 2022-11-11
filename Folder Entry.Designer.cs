
namespace Explorer_Tools
{
    partial class FolderEntry
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
            this.btn_FolderIcon = new System.Windows.Forms.Button();
            this.rtb_FolderInfo = new System.Windows.Forms.RichTextBox();
            this.btn_Options = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.tb_ThumbText = new System.Windows.Forms.TextBox();
            this.btn_Expand = new System.Windows.Forms.Button();
            this.tlp_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.AutoSize = true;
            this.tlp_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Main.ColumnCount = 5;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.Controls.Add(this.btn_FolderIcon, 0, 0);
            this.tlp_Main.Controls.Add(this.rtb_FolderInfo, 0, 1);
            this.tlp_Main.Controls.Add(this.btn_Options, 1, 0);
            this.tlp_Main.Controls.Add(this.btn_Select, 2, 0);
            this.tlp_Main.Controls.Add(this.tb_ThumbText, 3, 0);
            this.tlp_Main.Controls.Add(this.btn_Expand, 4, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.Size = new System.Drawing.Size(333, 150);
            this.tlp_Main.TabIndex = 2;
            this.tlp_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn_FolderIcon
            // 
            this.btn_FolderIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FolderIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FolderIcon.Image = global::Explorer_Tools.Properties.Resources.FolderTempIcon;
            this.btn_FolderIcon.Location = new System.Drawing.Point(0, 0);
            this.btn_FolderIcon.Margin = new System.Windows.Forms.Padding(0);
            this.btn_FolderIcon.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_FolderIcon.Name = "btn_FolderIcon";
            this.btn_FolderIcon.Size = new System.Drawing.Size(30, 30);
            this.btn_FolderIcon.TabIndex = 5;
            this.btn_FolderIcon.UseVisualStyleBackColor = true;
            // 
            // rtb_FolderInfo
            // 
            this.tlp_Main.SetColumnSpan(this.rtb_FolderInfo, 5);
            this.rtb_FolderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_FolderInfo.Location = new System.Drawing.Point(3, 33);
            this.rtb_FolderInfo.Name = "rtb_FolderInfo";
            this.rtb_FolderInfo.Size = new System.Drawing.Size(327, 114);
            this.rtb_FolderInfo.TabIndex = 2;
            this.rtb_FolderInfo.Text = "No Description Available";
            this.rtb_FolderInfo.TextChanged += new System.EventHandler(this.rtb_FolderInfo_TextChanged);
            // 
            // btn_Options
            // 
            this.btn_Options.AutoSize = true;
            this.btn_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Options.Image = global::Explorer_Tools.Properties.Resources.EditTempIcon;
            this.btn_Options.Location = new System.Drawing.Point(30, 0);
            this.btn_Options.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Options.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(30, 30);
            this.btn_Options.TabIndex = 3;
            this.btn_Options.UseVisualStyleBackColor = true;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.AutoEllipsis = true;
            this.btn_Select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Select.Location = new System.Drawing.Point(60, 0);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(123, 30);
            this.btn_Select.TabIndex = 4;
            this.btn_Select.Text = "ButtonButtonButtonButton";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            this.btn_Select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Select_MouseClick);
            // 
            // tb_ThumbText
            // 
            this.tb_ThumbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ThumbText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ThumbText.Location = new System.Drawing.Point(183, 0);
            this.tb_ThumbText.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ThumbText.Multiline = true;
            this.tb_ThumbText.Name = "tb_ThumbText";
            this.tb_ThumbText.ReadOnly = true;
            this.tb_ThumbText.Size = new System.Drawing.Size(120, 30);
            this.tb_ThumbText.TabIndex = 6;
            this.tb_ThumbText.Text = "NO DATA";
            this.tb_ThumbText.TextChanged += new System.EventHandler(this.tb_ThumbText_TextChanged);
            // 
            // btn_Expand
            // 
            this.btn_Expand.BackColor = System.Drawing.Color.White;
            this.btn_Expand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Expand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expand.Location = new System.Drawing.Point(303, 0);
            this.btn_Expand.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Expand.Name = "btn_Expand";
            this.btn_Expand.Size = new System.Drawing.Size(30, 30);
            this.btn_Expand.TabIndex = 7;
            this.btn_Expand.Text = "↓";
            this.btn_Expand.UseVisualStyleBackColor = false;
            this.btn_Expand.Click += new System.EventHandler(this.btn_Expand_Click);
            // 
            // FolderEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlp_Main);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(0, 30);
            this.Name = "FolderEntry";
            this.Size = new System.Drawing.Size(333, 150);
            this.Load += new System.EventHandler(this.FolderEntry_Load);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.RichTextBox rtb_FolderInfo;
        private System.Windows.Forms.Button btn_Options;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_FolderIcon;
        private System.Windows.Forms.TextBox tb_ThumbText;
        private System.Windows.Forms.Button btn_Expand;
    }
}
