
namespace Explorer_Tools
{
    partial class Text_Entry
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
            this.rtb_Content = new System.Windows.Forms.RichTextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel_MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.panel_MainLayout.ColumnCount = 3;
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_MainLayout.Controls.Add(this.lb_FileName, 1, 0);
            this.panel_MainLayout.Controls.Add(this.btn_Interact, 2, 0);
            this.panel_MainLayout.Controls.Add(this.pb_Icon, 0, 0);
            this.panel_MainLayout.Controls.Add(this.rtb_Content, 1, 1);
            this.panel_MainLayout.Controls.Add(this.btn_Save, 1, 2);
            this.panel_MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MainLayout.Location = new System.Drawing.Point(0, 0);
            this.panel_MainLayout.Name = "tableLayoutPanel1";
            this.panel_MainLayout.RowCount = 3;
            this.panel_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_MainLayout.Size = new System.Drawing.Size(200, 200);
            this.panel_MainLayout.TabIndex = 0;
            // 
            // lb_FileName
            // 
            this.lb_FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_FileName.Location = new System.Drawing.Point(33, 0);
            this.lb_FileName.Name = "lb_FileName";
            this.lb_FileName.Size = new System.Drawing.Size(134, 30);
            this.lb_FileName.TabIndex = 0;
            this.lb_FileName.Text = "DOCUMENT NAME";
            this.lb_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Interact
            // 
            this.btn_Interact.Location = new System.Drawing.Point(173, 3);
            this.btn_Interact.Name = "btn_Interact";
            this.btn_Interact.Size = new System.Drawing.Size(24, 23);
            this.btn_Interact.TabIndex = 1;
            this.btn_Interact.Text = "?";
            this.btn_Interact.UseVisualStyleBackColor = true;
            // 
            // pb_Icon
            // 
            this.pb_Icon.Image = global::Explorer_Tools.Properties.Resources.FolderTempIcon;
            this.pb_Icon.Location = new System.Drawing.Point(0, 0);
            this.pb_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(30, 30);
            this.pb_Icon.TabIndex = 2;
            this.pb_Icon.TabStop = false;
            // 
            // rtb_Content
            // 
            this.rtb_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Content.Location = new System.Drawing.Point(33, 33);
            this.rtb_Content.Name = "rtb_Content";
            this.rtb_Content.Size = new System.Drawing.Size(134, 143);
            this.rtb_Content.TabIndex = 3;
            this.rtb_Content.Text = "";
            this.rtb_Content.TextChanged += new System.EventHandler(this.rtb_Content_TextChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.AutoSize = true;
            this.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(35, 179);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(130, 21);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Text_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_MainLayout);
            this.MaximumSize = new System.Drawing.Size(200, 200);
            this.Name = "Text_Entry";
            this.Size = new System.Drawing.Size(200, 200);
            this.Load += new System.EventHandler(this.TextEntry_Load);
            this.panel_MainLayout.ResumeLayout(false);
            this.panel_MainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_MainLayout;
        private System.Windows.Forms.Label lb_FileName;
        private System.Windows.Forms.Button btn_Interact;
        private System.Windows.Forms.PictureBox pb_Icon;
        private System.Windows.Forms.RichTextBox rtb_Content;
        private System.Windows.Forms.Button btn_Save;
    }
}
