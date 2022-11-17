
namespace Explorer_Tools
{
    partial class Folder_Explorer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.btn_GoUp = new System.Windows.Forms.Button();
            this.tlp_Content = new System.Windows.Forms.TableLayoutPanel();
            this.ico_Folder = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pn_Label = new System.Windows.Forms.Panel();
            this.lb_FolderName = new System.Windows.Forms.Label();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Folder)).BeginInit();
            this.pn_Label.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.AutoSize = true;
            this.tlp_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Main.ColumnCount = 4;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.Controls.Add(this.btn_GoUp, 2, 0);
            this.tlp_Main.Controls.Add(this.tlp_Content, 0, 1);
            this.tlp_Main.Controls.Add(this.ico_Folder, 0, 0);
            this.tlp_Main.Controls.Add(this.btn_Close, 3, 0);
            this.tlp_Main.Controls.Add(this.pn_Label, 1, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(300, 450);
            this.tlp_Main.TabIndex = 0;
            // 
            // btn_GoUp
            // 
            this.btn_GoUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_GoUp.Location = new System.Drawing.Point(241, 0);
            this.btn_GoUp.Margin = new System.Windows.Forms.Padding(0);
            this.btn_GoUp.Name = "btn_GoUp";
            this.btn_GoUp.Size = new System.Drawing.Size(29, 30);
            this.btn_GoUp.TabIndex = 7;
            this.btn_GoUp.Text = "↑";
            this.btn_GoUp.UseVisualStyleBackColor = true;
            this.btn_GoUp.Click += new System.EventHandler(this.btn_GoUp_Click);
            // 
            // tlp_Content
            // 
            this.tlp_Content.AutoScroll = true;
            this.tlp_Content.AutoSize = true;
            this.tlp_Content.ColumnCount = 1;
            this.tlp_Main.SetColumnSpan(this.tlp_Content, 4);
            this.tlp_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Content.Location = new System.Drawing.Point(0, 30);
            this.tlp_Content.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Content.MinimumSize = new System.Drawing.Size(50, 50);
            this.tlp_Content.Name = "tlp_Content";
            this.tlp_Content.Padding = new System.Windows.Forms.Padding(1);
            this.tlp_Content.RowCount = 1;
            this.tlp_Content.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Content.Size = new System.Drawing.Size(300, 420);
            this.tlp_Content.TabIndex = 6;
            this.tlp_Content.SizeChanged += new System.EventHandler(this.tlp_Content_SizeChanged);
            // 
            // ico_Folder
            // 
            this.ico_Folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ico_Folder.Location = new System.Drawing.Point(0, 0);
            this.ico_Folder.Margin = new System.Windows.Forms.Padding(0);
            this.ico_Folder.Name = "ico_Folder";
            this.ico_Folder.Size = new System.Drawing.Size(30, 30);
            this.ico_Folder.TabIndex = 2;
            this.ico_Folder.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Close.Location = new System.Drawing.Point(270, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // pn_Label
            // 
            this.pn_Label.Controls.Add(this.lb_FolderName);
            this.pn_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Label.Location = new System.Drawing.Point(30, 0);
            this.pn_Label.Margin = new System.Windows.Forms.Padding(0);
            this.pn_Label.Name = "pn_Label";
            this.pn_Label.Size = new System.Drawing.Size(210, 30);
            this.pn_Label.TabIndex = 5;
            // 
            // lb_FolderName
            // 
            this.lb_FolderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_FolderName.Location = new System.Drawing.Point(0, 0);
            this.lb_FolderName.Margin = new System.Windows.Forms.Padding(0);
            this.lb_FolderName.Name = "lb_FolderName";
            this.lb_FolderName.Size = new System.Drawing.Size(210, 30);
            this.lb_FolderName.TabIndex = 1;
            this.lb_FolderName.Text = "FOLDER NAME HERE";
            this.lb_FolderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Folder_Explorer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 0);
            this.Name = "Folder_Explorer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Folder Explorer";
            this.Resize += new System.EventHandler(this.Folder_Explorer_Resize);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Folder)).EndInit();
            this.pn_Label.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.PictureBox ico_Folder;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pn_Label;
        private System.Windows.Forms.Label lb_FolderName;
        private System.Windows.Forms.TableLayoutPanel tlp_Content;
        private System.Windows.Forms.Button btn_GoUp;
    }
}