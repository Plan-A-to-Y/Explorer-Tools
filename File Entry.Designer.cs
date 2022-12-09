
namespace Explorer_Tools
{
    partial class File_Entry
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
            this.panel_MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lb_FileName = new System.Windows.Forms.Label();
            this.btn_Interact = new System.Windows.Forms.Button();
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.btn_Details = new System.Windows.Forms.Button();
            this.rtb_Details = new System.Windows.Forms.RichTextBox();
            this.panel_MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_MainLayout
            // 
            this.panel_MainLayout.AutoSize = true;
            this.panel_MainLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_MainLayout.BackColor = System.Drawing.Color.Transparent;
            this.panel_MainLayout.ColumnCount = 4;
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_MainLayout.Controls.Add(this.lb_FileName, 1, 0);
            this.panel_MainLayout.Controls.Add(this.btn_Interact, 2, 0);
            this.panel_MainLayout.Controls.Add(this.pb_Icon, 0, 0);
            this.panel_MainLayout.Controls.Add(this.btn_Details, 3, 0);
            this.panel_MainLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_MainLayout.Location = new System.Drawing.Point(0, 0);
            this.panel_MainLayout.MinimumSize = new System.Drawing.Size(200, 30);
            this.panel_MainLayout.Name = "panel_MainLayout";
            this.panel_MainLayout.RowCount = 1;
            this.panel_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_MainLayout.Size = new System.Drawing.Size(200, 30);
            this.panel_MainLayout.TabIndex = 0;
            this.panel_MainLayout.Click += new System.EventHandler(this.SelectionClick);
            // 
            // lb_FileName
            // 
            this.lb_FileName.AutoEllipsis = true;
            this.lb_FileName.AutoSize = true;
            this.lb_FileName.BackColor = System.Drawing.Color.Transparent;
            this.lb_FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_FileName.Location = new System.Drawing.Point(30, 0);
            this.lb_FileName.Margin = new System.Windows.Forms.Padding(0);
            this.lb_FileName.MinimumSize = new System.Drawing.Size(100, 30);
            this.lb_FileName.Name = "lb_FileName";
            this.lb_FileName.Size = new System.Drawing.Size(110, 30);
            this.lb_FileName.TabIndex = 0;
            this.lb_FileName.Tag = "";
            this.lb_FileName.Text = "FILE_NAME";
            this.lb_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_FileName.Click += new System.EventHandler(this.SelectionClick);
            this.lb_FileName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClickAndDrag);
            // 
            // btn_Interact
            // 
            this.btn_Interact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Interact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Interact.Location = new System.Drawing.Point(140, 0);
            this.btn_Interact.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Interact.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_Interact.Name = "btn_Interact";
            this.btn_Interact.Size = new System.Drawing.Size(30, 30);
            this.btn_Interact.TabIndex = 1;
            this.btn_Interact.Text = "?";
            this.btn_Interact.UseVisualStyleBackColor = true;
            // 
            // pb_Icon
            // 
            this.pb_Icon.Image = global::Explorer_Tools.Properties.Resources.FolderTempIcon;
            this.pb_Icon.Location = new System.Drawing.Point(0, 0);
            this.pb_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.pb_Icon.MinimumSize = new System.Drawing.Size(30, 30);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(30, 30);
            this.pb_Icon.TabIndex = 2;
            this.pb_Icon.TabStop = false;
            this.pb_Icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClickAndDrag);
            // 
            // btn_Details
            // 
            this.btn_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Details.Location = new System.Drawing.Point(170, 0);
            this.btn_Details.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(30, 30);
            this.btn_Details.TabIndex = 3;
            this.btn_Details.Text = "↓";
            this.btn_Details.UseVisualStyleBackColor = true;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // rtb_Details
            // 
            this.rtb_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Details.Location = new System.Drawing.Point(0, 30);
            this.rtb_Details.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Details.MinimumSize = new System.Drawing.Size(0, 30);
            this.rtb_Details.Name = "rtb_Details";
            this.rtb_Details.Size = new System.Drawing.Size(200, 30);
            this.rtb_Details.TabIndex = 4;
            this.rtb_Details.Text = "";
            // 
            // File_Entry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.rtb_Details);
            this.Controls.Add(this.panel_MainLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(200, 30);
            this.Name = "File_Entry";
            this.Size = new System.Drawing.Size(200, 30);
            this.Load += new System.EventHandler(this.FileEntry_Load);
            this.panel_MainLayout.ResumeLayout(false);
            this.panel_MainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_MainLayout;
        private System.Windows.Forms.Button btn_Interact;
        private System.Windows.Forms.PictureBox pb_Icon;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.RichTextBox rtb_Details;
        public System.Windows.Forms.Label lb_FileName;
    }
}
