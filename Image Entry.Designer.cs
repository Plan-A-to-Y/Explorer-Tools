
namespace Explorer_Tools
{
    partial class Image_Entry
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
            this.lb_ImageName = new System.Windows.Forms.Label();
            this.lb_ImageProperties = new System.Windows.Forms.Label();
            this.pb_Thumbnail = new System.Windows.Forms.PictureBox();
            this.panel_MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_MainLayout
            // 
            this.panel_MainLayout.ColumnCount = 2;
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_MainLayout.Controls.Add(this.lb_ImageName, 0, 1);
            this.panel_MainLayout.Controls.Add(this.lb_ImageProperties, 0, 1);
            this.panel_MainLayout.Controls.Add(this.pb_Thumbnail, 0, 0);
            this.panel_MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MainLayout.Location = new System.Drawing.Point(0, 0);
            this.panel_MainLayout.Name = "panel_MainLayout";
            this.panel_MainLayout.RowCount = 2;
            this.panel_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.panel_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_MainLayout.Size = new System.Drawing.Size(200, 200);
            this.panel_MainLayout.TabIndex = 0;
            // 
            // lb_ImageName
            // 
            this.lb_ImageName.AutoEllipsis = true;
            this.lb_ImageName.AutoSize = true;
            this.lb_ImageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ImageName.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ImageName.Location = new System.Drawing.Point(3, 180);
            this.lb_ImageName.Name = "lb_ImageName";
            this.lb_ImageName.Size = new System.Drawing.Size(94, 20);
            this.lb_ImageName.TabIndex = 2;
            this.lb_ImageName.Text = "IMAGE NAME";
            this.lb_ImageName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_ImageProperties
            // 
            this.lb_ImageProperties.AutoSize = true;
            this.lb_ImageProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ImageProperties.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ImageProperties.Location = new System.Drawing.Point(103, 180);
            this.lb_ImageProperties.Name = "lb_ImageProperties";
            this.lb_ImageProperties.Size = new System.Drawing.Size(94, 20);
            this.lb_ImageProperties.TabIndex = 0;
            this.lb_ImageProperties.Text = "IMAGE DETAILS";
            this.lb_ImageProperties.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pb_Thumbnail
            // 
            this.panel_MainLayout.SetColumnSpan(this.pb_Thumbnail, 2);
            this.pb_Thumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Thumbnail.Location = new System.Drawing.Point(10, 0);
            this.pb_Thumbnail.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pb_Thumbnail.Name = "pb_Thumbnail";
            this.pb_Thumbnail.Size = new System.Drawing.Size(180, 180);
            this.pb_Thumbnail.TabIndex = 1;
            this.pb_Thumbnail.TabStop = false;
            this.pb_Thumbnail.Click += new System.EventHandler(this.SelectionClick);
            // 
            // Image_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_MainLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(200, 200);
            this.Name = "Image_Entry";
            this.Size = new System.Drawing.Size(200, 200);
            this.Load += new System.EventHandler(this.ImageEntry_Load);
            this.panel_MainLayout.ResumeLayout(false);
            this.panel_MainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_MainLayout;
        private System.Windows.Forms.Label lb_ImageProperties;
        private System.Windows.Forms.PictureBox pb_Thumbnail;
        private System.Windows.Forms.Label lb_ImageName;
    }
}
