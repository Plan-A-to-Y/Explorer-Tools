
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
            this.s = new System.Windows.Forms.TableLayoutPanel();
            this.btn_FolderIcon = new System.Windows.Forms.Button();
            this.rtb_FolderInfo = new System.Windows.Forms.RichTextBox();
            this.btn_Options = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.s.SuspendLayout();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.s.ColumnCount = 4;
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.s.Controls.Add(this.btn_FolderIcon, 0, 0);
            this.s.Controls.Add(this.rtb_FolderInfo, 0, 1);
            this.s.Controls.Add(this.btn_Options, 1, 0);
            this.s.Controls.Add(this.btn_Select, 2, 0);
            this.s.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.s.Location = new System.Drawing.Point(0, 0);
            this.s.Name = "s";
            this.s.RowCount = 2;
            this.s.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.s.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.s.Size = new System.Drawing.Size(203, 150);
            this.s.TabIndex = 2;
            this.s.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            this.s.SetColumnSpan(this.rtb_FolderInfo, 3);
            this.rtb_FolderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_FolderInfo.Location = new System.Drawing.Point(3, 33);
            this.rtb_FolderInfo.Name = "rtb_FolderInfo";
            this.rtb_FolderInfo.Size = new System.Drawing.Size(187, 114);
            this.rtb_FolderInfo.TabIndex = 2;
            this.rtb_FolderInfo.Text = "This is a Documents folder";
            // 
            // btn_Options
            // 
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
            // 
            // btn_Select
            // 
            this.btn_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Select.Location = new System.Drawing.Point(60, 0);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(133, 30);
            this.btn_Select.TabIndex = 4;
            this.btn_Select.Text = "button1";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            this.btn_Select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Select_MouseClick);
            // 
            // FolderEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.s);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(120, 30);
            this.Name = "FolderEntry";
            this.Size = new System.Drawing.Size(203, 150);
            this.Load += new System.EventHandler(this.FolderEntry_Load);
            this.s.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel s;
        private System.Windows.Forms.RichTextBox rtb_FolderInfo;
        private System.Windows.Forms.Button btn_Options;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_FolderIcon;
    }
}
