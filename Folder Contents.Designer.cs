
namespace Explorer_Tools
{
    partial class Folder_Contents
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
            this.panel_Content = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_TopLeft = new System.Windows.Forms.Panel();
            this.pn_TopRight = new System.Windows.Forms.Panel();
            this.pn_LeftBorder = new System.Windows.Forms.Panel();
            this.pn_TopBorder = new System.Windows.Forms.Panel();
            this.pn_BottomRight = new System.Windows.Forms.Panel();
            this.panel_Header = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_ToggleFull = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pn_RightBorder = new System.Windows.Forms.Panel();
            this.pn_BottomLeft = new System.Windows.Forms.Panel();
            this.pn_BottomBorder = new System.Windows.Forms.Panel();
            this.color_Dialog = new System.Windows.Forms.ColorDialog();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.tlp_Main.SuspendLayout();
            this.panel_Content.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 3;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp_Main.Controls.Add(this.panel_Content, 1, 2);
            this.tlp_Main.Controls.Add(this.pn_TopLeft, 0, 0);
            this.tlp_Main.Controls.Add(this.pn_TopRight, 2, 0);
            this.tlp_Main.Controls.Add(this.pn_LeftBorder, 0, 1);
            this.tlp_Main.Controls.Add(this.pn_TopBorder, 1, 0);
            this.tlp_Main.Controls.Add(this.pn_BottomRight, 2, 3);
            this.tlp_Main.Controls.Add(this.panel_Header, 1, 1);
            this.tlp_Main.Controls.Add(this.pn_RightBorder, 2, 1);
            this.tlp_Main.Controls.Add(this.pn_BottomLeft, 0, 3);
            this.tlp_Main.Controls.Add(this.pn_BottomBorder, 1, 3);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 4;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp_Main.Size = new System.Drawing.Size(800, 450);
            this.tlp_Main.TabIndex = 1;
            // 
            // panel_Content
            // 
            this.panel_Content.AutoScroll = true;
            this.panel_Content.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.panel_Content.AutoSize = true;
            this.panel_Content.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Content.Controls.Add(this.panel2);
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(8, 38);
            this.panel_Content.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(784, 404);
            this.panel_Content.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 0);
            this.panel2.TabIndex = 3;
            // 
            // pn_TopLeft
            // 
            this.pn_TopLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_TopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_TopLeft.Location = new System.Drawing.Point(0, 0);
            this.pn_TopLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pn_TopLeft.Name = "pn_TopLeft";
            this.pn_TopLeft.Size = new System.Drawing.Size(8, 8);
            this.pn_TopLeft.TabIndex = 8;
            this.pn_TopLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_TopLeft_Paint);
            this.pn_TopLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.pn_TopLeft.MouseLeave += new System.EventHandler(this.Resize_MouseLeave);
            this.pn_TopLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.pn_TopLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
            // 
            // pn_TopRight
            // 
            this.pn_TopRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_TopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_TopRight.Location = new System.Drawing.Point(792, 0);
            this.pn_TopRight.Margin = new System.Windows.Forms.Padding(0);
            this.pn_TopRight.Name = "pn_TopRight";
            this.pn_TopRight.Size = new System.Drawing.Size(8, 8);
            this.pn_TopRight.TabIndex = 7;
            this.pn_TopRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_TopRight_Paint);
            this.pn_TopRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.pn_TopRight.MouseLeave += new System.EventHandler(this.Resize_MouseLeave);
            this.pn_TopRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.pn_TopRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
            // 
            // pn_LeftBorder
            // 
            this.pn_LeftBorder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_LeftBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_LeftBorder.Location = new System.Drawing.Point(0, 8);
            this.pn_LeftBorder.Margin = new System.Windows.Forms.Padding(0);
            this.pn_LeftBorder.Name = "pn_LeftBorder";
            this.tlp_Main.SetRowSpan(this.pn_LeftBorder, 2);
            this.pn_LeftBorder.Size = new System.Drawing.Size(8, 434);
            this.pn_LeftBorder.TabIndex = 6;
            this.pn_LeftBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Left_Paint);
            this.pn_LeftBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.pn_LeftBorder.MouseLeave += new System.EventHandler(this.Resize_MouseLeave);
            this.pn_LeftBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.pn_LeftBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
            // 
            // pn_TopBorder
            // 
            this.pn_TopBorder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_TopBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_TopBorder.Location = new System.Drawing.Point(8, 0);
            this.pn_TopBorder.Margin = new System.Windows.Forms.Padding(0);
            this.pn_TopBorder.Name = "pn_TopBorder";
            this.pn_TopBorder.Size = new System.Drawing.Size(784, 8);
            this.pn_TopBorder.TabIndex = 3;
            this.pn_TopBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_TopBorder_Paint);
            this.pn_TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.pn_TopBorder.MouseLeave += new System.EventHandler(this.Resize_MouseLeave);
            this.pn_TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.pn_TopBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
            // 
            // pn_BottomRight
            // 
            this.pn_BottomRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_BottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_BottomRight.Location = new System.Drawing.Point(792, 442);
            this.pn_BottomRight.Margin = new System.Windows.Forms.Padding(0);
            this.pn_BottomRight.Name = "pn_BottomRight";
            this.pn_BottomRight.Size = new System.Drawing.Size(8, 8);
            this.pn_BottomRight.TabIndex = 5;
            this.pn_BottomRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.pn_BottomRight.MouseLeave += new System.EventHandler(this.Resize_MouseLeave);
            this.pn_BottomRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.pn_BottomRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
            // 
            // panel_Header
            // 
            this.panel_Header.ColumnCount = 5;
            this.panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_Header.Controls.Add(this.btn_Minimize, 2, 0);
            this.panel_Header.Controls.Add(this.btn_ToggleFull, 3, 0);
            this.panel_Header.Controls.Add(this.btn_Close, 4, 0);
            this.panel_Header.Controls.Add(this.btn_Edit, 0, 0);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Header.Location = new System.Drawing.Point(8, 8);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.RowCount = 1;
            this.panel_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_Header.Size = new System.Drawing.Size(784, 30);
            this.panel_Header.TabIndex = 1;
            this.panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseDown);
            this.panel_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Folder_Contents_MouseMove);
            this.panel_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseUp);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Location = new System.Drawing.Point(694, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.Text = "_";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            // 
            // btn_ToggleFull
            // 
            this.btn_ToggleFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ToggleFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ToggleFull.Image = global::Explorer_Tools.Properties.Resources.ToggleFull_0;
            this.btn_ToggleFull.Location = new System.Drawing.Point(724, 0);
            this.btn_ToggleFull.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ToggleFull.Name = "btn_ToggleFull";
            this.btn_ToggleFull.Size = new System.Drawing.Size(30, 30);
            this.btn_ToggleFull.TabIndex = 1;
            this.btn_ToggleFull.UseVisualStyleBackColor = true;
            this.btn_ToggleFull.Click += new System.EventHandler(this.btn_ToggleFull_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(754, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pn_RightBorder
            // 
            this.pn_RightBorder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_RightBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_RightBorder.Location = new System.Drawing.Point(792, 8);
            this.pn_RightBorder.Margin = new System.Windows.Forms.Padding(0);
            this.pn_RightBorder.Name = "pn_RightBorder";
            this.tlp_Main.SetRowSpan(this.pn_RightBorder, 2);
            this.pn_RightBorder.Size = new System.Drawing.Size(8, 434);
            this.pn_RightBorder.TabIndex = 4;
            this.pn_RightBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Right_Paint);
            this.pn_RightBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.pn_RightBorder.MouseLeave += new System.EventHandler(this.Resize_MouseLeave);
            this.pn_RightBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.pn_RightBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
            // 
            // pn_BottomLeft
            // 
            this.pn_BottomLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_BottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_BottomLeft.Location = new System.Drawing.Point(0, 442);
            this.pn_BottomLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pn_BottomLeft.Name = "pn_BottomLeft";
            this.pn_BottomLeft.Size = new System.Drawing.Size(8, 8);
            this.pn_BottomLeft.TabIndex = 3;
            this.pn_BottomLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.pn_BottomLeft.MouseLeave += new System.EventHandler(this.Resize_MouseLeave);
            this.pn_BottomLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.pn_BottomLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
            // 
            // pn_BottomBorder
            // 
            this.pn_BottomBorder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_BottomBorder.Location = new System.Drawing.Point(8, 442);
            this.pn_BottomBorder.Margin = new System.Windows.Forms.Padding(0);
            this.pn_BottomBorder.Name = "pn_BottomBorder";
            this.pn_BottomBorder.Size = new System.Drawing.Size(784, 8);
            this.pn_BottomBorder.TabIndex = 2;
            this.pn_BottomBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.pn_BottomBorder.MouseLeave += new System.EventHandler(this.Resize_MouseLeave);
            this.pn_BottomBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.pn_BottomBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
            // 
            // color_Dialog
            // 
            this.color_Dialog.AnyColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Image = global::Explorer_Tools.Properties.Resources.EditTempIcon;
            this.btn_Edit.Location = new System.Drawing.Point(0, 0);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(30, 30);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Folder_Contents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 250);
            this.Name = "Folder_Contents";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Folder_Contents";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Folder_Contents_MouseMove);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            this.panel_Content.ResumeLayout(false);
            this.panel_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.ColorDialog color_Dialog;
        private System.Windows.Forms.TableLayoutPanel panel_Header;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_ToggleFull;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pn_LeftBorder;
        private System.Windows.Forms.Panel pn_BottomRight;
        private System.Windows.Forms.Panel pn_RightBorder;
        private System.Windows.Forms.Panel pn_BottomLeft;
        private System.Windows.Forms.Panel pn_BottomBorder;
        private System.Windows.Forms.Panel pn_TopLeft;
        private System.Windows.Forms.Panel pn_TopRight;
        private System.Windows.Forms.Panel pn_TopBorder;
        private System.Windows.Forms.FlowLayoutPanel panel_Content;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Edit;
    }
}