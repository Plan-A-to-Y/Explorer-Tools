
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
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.lb_FileName = new System.Windows.Forms.Label();
            this.btn_Interact = new System.Windows.Forms.Button();
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.btn_Details = new System.Windows.Forms.Button();
            this.btn_DetailList = new System.Windows.Forms.Button();
            this.tlp_Details = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_Details = new System.Windows.Forms.RichTextBox();
            this.flp_Details = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_DetailsPlaceholder = new System.Windows.Forms.Label();
            this.cb_ShowNotes = new System.Windows.Forms.CheckBox();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.tlp_Details.SuspendLayout();
            this.flp_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.AutoSize = true;
            this.tlp_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Main.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Main.ColumnCount = 5;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.Controls.Add(this.lb_FileName, 1, 0);
            this.tlp_Main.Controls.Add(this.btn_Interact, 3, 0);
            this.tlp_Main.Controls.Add(this.pb_Icon, 0, 0);
            this.tlp_Main.Controls.Add(this.btn_Details, 4, 0);
            this.tlp_Main.Controls.Add(this.btn_DetailList, 2, 0);
            this.tlp_Main.Controls.Add(this.tlp_Details, 0, 1);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.MinimumSize = new System.Drawing.Size(200, 30);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.Size = new System.Drawing.Size(200, 132);
            this.tlp_Main.TabIndex = 0;
            this.tlp_Main.Click += new System.EventHandler(this.SelectionClick);
            // 
            // lb_FileName
            // 
            this.lb_FileName.AutoEllipsis = true;
            this.lb_FileName.AutoSize = true;
            this.lb_FileName.BackColor = System.Drawing.Color.Transparent;
            this.lb_FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_FileName.Location = new System.Drawing.Point(30, 0);
            this.lb_FileName.Margin = new System.Windows.Forms.Padding(0);
            this.lb_FileName.Name = "lb_FileName";
            this.lb_FileName.Size = new System.Drawing.Size(65, 32);
            this.lb_FileName.TabIndex = 0;
            this.lb_FileName.Tag = "";
            this.lb_FileName.Text = "FILE_NAME";
            this.lb_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_FileName.Click += new System.EventHandler(this.SelectionClick);
            this.lb_FileName.DoubleClick += new System.EventHandler(this.lb_FileName_DoubleClick);
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
            this.btn_Interact.Size = new System.Drawing.Size(30, 32);
            this.btn_Interact.TabIndex = 1;
            this.btn_Interact.Tag = "Fore:ST Back:S BtnBorder:T";
            this.btn_Interact.Text = "?";
            this.btn_Interact.UseVisualStyleBackColor = true;
            // 
            // pb_Icon
            // 
            this.pb_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Icon.Image = global::Explorer_Tools.Properties.Resources.FolderTempIcon;
            this.pb_Icon.Location = new System.Drawing.Point(0, 0);
            this.pb_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.pb_Icon.MinimumSize = new System.Drawing.Size(30, 30);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(30, 32);
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
            this.btn_Details.Size = new System.Drawing.Size(30, 32);
            this.btn_Details.TabIndex = 3;
            this.btn_Details.Tag = "Fore:ST Back:S BtnBorder:T";
            this.btn_Details.Text = "↓";
            this.btn_Details.UseVisualStyleBackColor = true;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // btn_DetailList
            // 
            this.btn_DetailList.AutoSize = true;
            this.btn_DetailList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DetailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DetailList.FlatAppearance.BorderSize = 0;
            this.btn_DetailList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DetailList.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DetailList.Location = new System.Drawing.Point(95, 0);
            this.btn_DetailList.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DetailList.Name = "btn_DetailList";
            this.btn_DetailList.Size = new System.Drawing.Size(45, 32);
            this.btn_DetailList.TabIndex = 4;
            this.btn_DetailList.Tag = "Fore:ST Back:S BtnBorder:T";
            this.btn_DetailList.Text = "Details 1\r\nDetails 2\r\n";
            this.btn_DetailList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DetailList.UseVisualStyleBackColor = true;
            // 
            // tlp_Details
            // 
            this.tlp_Details.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Details.ColumnCount = 1;
            this.tlp_Main.SetColumnSpan(this.tlp_Details, 5);
            this.tlp_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Details.Controls.Add(this.rtb_Details, 0, 1);
            this.tlp_Details.Controls.Add(this.flp_Details, 0, 0);
            this.tlp_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Details.Location = new System.Drawing.Point(0, 32);
            this.tlp_Details.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Details.Name = "tlp_Details";
            this.tlp_Details.RowCount = 2;
            this.tlp_Details.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Details.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Details.Size = new System.Drawing.Size(200, 100);
            this.tlp_Details.TabIndex = 5;
            // 
            // rtb_Details
            // 
            this.tlp_Details.SetColumnSpan(this.rtb_Details, 5);
            this.rtb_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Details.Location = new System.Drawing.Point(0, 25);
            this.rtb_Details.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Details.Name = "rtb_Details";
            this.rtb_Details.Size = new System.Drawing.Size(200, 75);
            this.rtb_Details.TabIndex = 5;
            this.rtb_Details.Text = "Notes for this file can be entered here for later use";
            this.rtb_Details.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtb_Details_ContentsResized);
            // 
            // flp_Details
            // 
            this.flp_Details.AutoSize = true;
            this.flp_Details.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_Details.Controls.Add(this.lb_DetailsPlaceholder);
            this.flp_Details.Controls.Add(this.cb_ShowNotes);
            this.flp_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Details.Location = new System.Drawing.Point(0, 0);
            this.flp_Details.Margin = new System.Windows.Forms.Padding(0);
            this.flp_Details.Name = "flp_Details";
            this.flp_Details.Size = new System.Drawing.Size(200, 25);
            this.flp_Details.TabIndex = 6;
            // 
            // lb_DetailsPlaceholder
            // 
            this.lb_DetailsPlaceholder.AutoSize = true;
            this.lb_DetailsPlaceholder.Location = new System.Drawing.Point(3, 0);
            this.lb_DetailsPlaceholder.Name = "lb_DetailsPlaceholder";
            this.lb_DetailsPlaceholder.Size = new System.Drawing.Size(69, 15);
            this.lb_DetailsPlaceholder.TabIndex = 0;
            this.lb_DetailsPlaceholder.Text = "IGNORE ME";
            // 
            // cb_ShowNotes
            // 
            this.cb_ShowNotes.AutoSize = true;
            this.cb_ShowNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ShowNotes.Location = new System.Drawing.Point(78, 3);
            this.cb_ShowNotes.Name = "cb_ShowNotes";
            this.cb_ShowNotes.Size = new System.Drawing.Size(86, 19);
            this.cb_ShowNotes.TabIndex = 1;
            this.cb_ShowNotes.Text = "Show Notes";
            this.cb_ShowNotes.UseVisualStyleBackColor = true;
            // 
            // File_Entry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlp_Main);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(200, 30);
            this.Name = "File_Entry";
            this.Size = new System.Drawing.Size(200, 132);
            this.Load += new System.EventHandler(this.FileEntry_Load);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.tlp_Details.ResumeLayout(false);
            this.tlp_Details.PerformLayout();
            this.flp_Details.ResumeLayout(false);
            this.flp_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.Button btn_Interact;
        private System.Windows.Forms.PictureBox pb_Icon;
        private System.Windows.Forms.Button btn_Details;
        public System.Windows.Forms.Label lb_FileName;
        private System.Windows.Forms.Button btn_DetailList;
        private System.Windows.Forms.TableLayoutPanel tlp_Details;
        private System.Windows.Forms.RichTextBox rtb_Details;
        private System.Windows.Forms.FlowLayoutPanel flp_Details;
        private System.Windows.Forms.Label lb_DetailsPlaceholder;
        private System.Windows.Forms.CheckBox cb_ShowNotes;
    }
}
