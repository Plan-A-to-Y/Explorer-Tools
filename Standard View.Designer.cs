
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
            this.pn_Sidebar = new System.Windows.Forms.Panel();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.splitter_Main = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // pn_Sidebar
            // 
            this.pn_Sidebar.AutoSize = true;
            this.pn_Sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.pn_Sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pn_Sidebar.MinimumSize = new System.Drawing.Size(100, 0);
            this.pn_Sidebar.Name = "pn_Sidebar";
            this.pn_Sidebar.Size = new System.Drawing.Size(100, 390);
            this.pn_Sidebar.TabIndex = 5;
            // 
            // pn_Main
            // 
            this.pn_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Main.Location = new System.Drawing.Point(100, 0);
            this.pn_Main.Margin = new System.Windows.Forms.Padding(0);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(816, 390);
            this.pn_Main.TabIndex = 6;
            // 
            // splitter_Main
            // 
            this.splitter_Main.Location = new System.Drawing.Point(100, 0);
            this.splitter_Main.Name = "splitter_Main";
            this.splitter_Main.Size = new System.Drawing.Size(3, 390);
            this.splitter_Main.TabIndex = 7;
            this.splitter_Main.TabStop = false;
            // 
            // form_StandardView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(916, 390);
            this.Controls.Add(this.splitter_Main);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.pn_Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "form_StandardView";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.folderContents_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Sidebar;
        private System.Windows.Forms.Panel pn_Main;
        private System.Windows.Forms.Splitter splitter_Main;
    }
}

