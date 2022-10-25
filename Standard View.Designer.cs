
namespace Explorer_Tools
{
    partial class form_StandardView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sc_Main = new System.Windows.Forms.SplitContainer();
            this.panel_folderContents = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.sc_Main)).BeginInit();
            this.sc_Main.Panel2.SuspendLayout();
            this.sc_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_Main
            // 
            this.sc_Main.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.sc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc_Main.IsSplitterFixed = true;
            this.sc_Main.Location = new System.Drawing.Point(0, 0);
            this.sc_Main.Margin = new System.Windows.Forms.Padding(0);
            this.sc_Main.Name = "sc_Main";
            this.sc_Main.Panel1MinSize = 300;
            // 
            // sc_Main.Panel2
            // 
            this.sc_Main.Panel2.Controls.Add(this.panel_folderContents);
            this.sc_Main.Size = new System.Drawing.Size(916, 390);
            this.sc_Main.SplitterDistance = 300;
            this.sc_Main.TabIndex = 1;
            // 
            // panel_folderContents
            // 
            this.panel_folderContents.AutoScroll = true;
            this.panel_folderContents.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.panel_folderContents.AutoSize = true;
            this.panel_folderContents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_folderContents.ColumnCount = 3;
            this.panel_folderContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.panel_folderContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.panel_folderContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.panel_folderContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_folderContents.Location = new System.Drawing.Point(0, 0);
            this.panel_folderContents.Margin = new System.Windows.Forms.Padding(0);
            this.panel_folderContents.MinimumSize = new System.Drawing.Size(200, 0);
            this.panel_folderContents.Name = "panel_folderContents";
            this.panel_folderContents.RowCount = 1;
            this.panel_folderContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 390F));
            this.panel_folderContents.Size = new System.Drawing.Size(612, 390);
            this.panel_folderContents.TabIndex = 0;
            this.panel_folderContents.SizeChanged += new System.EventHandler(this.folderContents_SizeChanged);
            this.panel_folderContents.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // form_StandardView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(916, 390);
            this.Controls.Add(this.sc_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "form_StandardView";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.folderContents_SizeChanged);
            this.sc_Main.Panel2.ResumeLayout(false);
            this.sc_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_Main)).EndInit();
            this.sc_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_Main;
        private System.Windows.Forms.TableLayoutPanel panel_folderContents;
    }
}

