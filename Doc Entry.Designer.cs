
namespace Explorer_Tools
{
    partial class Doc_Entry
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Dummy = new System.Windows.Forms.TextBox();
            this.panel_MainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MainLayout
            // 
            this.panel_MainLayout.ColumnCount = 3;
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_MainLayout.Controls.Add(this.button1, 2, 0);
            this.panel_MainLayout.Controls.Add(this.tb_Dummy, 0, 0);
            this.panel_MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MainLayout.Location = new System.Drawing.Point(0, 0);
            this.panel_MainLayout.Name = "panel_MainLayout";
            this.panel_MainLayout.RowCount = 3;
            this.panel_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_MainLayout.Size = new System.Drawing.Size(200, 200);
            this.panel_MainLayout.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_Dummy
            // 
            this.tb_Dummy.Location = new System.Drawing.Point(3, 3);
            this.tb_Dummy.Name = "tb_Dummy";
            this.tb_Dummy.Size = new System.Drawing.Size(24, 23);
            this.tb_Dummy.TabIndex = 1;
            this.tb_Dummy.Text = "W";
            this.tb_Dummy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Doc_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_MainLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(200, 200);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Doc_Entry";
            this.Size = new System.Drawing.Size(200, 200);
            this.panel_MainLayout.ResumeLayout(false);
            this.panel_MainLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_MainLayout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_Dummy;
    }
}
