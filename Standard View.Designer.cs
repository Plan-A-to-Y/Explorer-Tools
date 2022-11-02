
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
            ((System.ComponentModel.ISupportInitialize)(this.sc_Main)).BeginInit();
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
            // 
            // sc_Main.Panel1
            // 
            this.sc_Main.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.sc_Main.Panel1MinSize = 300;
            // 
            // sc_Main.Panel2
            // 
            this.sc_Main.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sc_Main.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.sc_Main.Size = new System.Drawing.Size(916, 390);
            this.sc_Main.SplitterDistance = 300;
            this.sc_Main.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.sc_Main)).EndInit();
            this.sc_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer sc_Main;
    }
}

