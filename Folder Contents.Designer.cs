﻿
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Header = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_ToggleFull = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Content = new System.Windows.Forms.FlowLayoutPanel();
            this.color_Dialog = new System.Windows.Forms.ColorDialog();
            this.pn_BottomBorder = new System.Windows.Forms.Panel();
            this.pn_BottomLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_Right = new System.Windows.Forms.Panel();
            this.pn_BottomRight = new System.Windows.Forms.Panel();
            this.pn_Left = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_Header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel_Header
            // 
            this.panel_Header.ColumnCount = 4;
            this.panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_Header.Controls.Add(this.btn_Minimize, 1, 0);
            this.panel_Header.Controls.Add(this.btn_ToggleFull, 2, 0);
            this.panel_Header.Controls.Add(this.btn_Close, 3, 0);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.RowCount = 1;
            this.panel_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_Header.Size = new System.Drawing.Size(800, 30);
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
            this.btn_Minimize.Location = new System.Drawing.Point(710, 0);
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
            this.btn_ToggleFull.Location = new System.Drawing.Point(740, 0);
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
            this.btn_Close.Location = new System.Drawing.Point(770, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.pn_Left, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pn_BottomRight, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pn_Right, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pn_BottomLeft, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel_Content, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pn_BottomBorder, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 420);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseDown);
            this.tableLayoutPanel2.MouseLeave += new System.EventHandler(this.tableLayoutPanel2_MouseLeave);
            this.tableLayoutPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseMove);
            this.tableLayoutPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseUp);
            // 
            // panel_Content
            // 
            this.panel_Content.AutoScroll = true;
            this.panel_Content.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.panel_Content.AutoSize = true;
            this.panel_Content.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Content.Controls.Add(this.panel2);
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(8, 0);
            this.panel_Content.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(784, 412);
            this.panel_Content.TabIndex = 1;
            // 
            // color_Dialog
            // 
            this.color_Dialog.AnyColor = true;
            // 
            // pn_BottomBorder
            // 
            this.pn_BottomBorder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_BottomBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_BottomBorder.Location = new System.Drawing.Point(8, 412);
            this.pn_BottomBorder.Margin = new System.Windows.Forms.Padding(0);
            this.pn_BottomBorder.Name = "pn_BottomBorder";
            this.pn_BottomBorder.Size = new System.Drawing.Size(784, 8);
            this.pn_BottomBorder.TabIndex = 2;
            // 
            // pn_BottomLeft
            // 
            this.pn_BottomLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_BottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_BottomLeft.Location = new System.Drawing.Point(0, 412);
            this.pn_BottomLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pn_BottomLeft.Name = "pn_BottomLeft";
            this.pn_BottomLeft.Size = new System.Drawing.Size(8, 8);
            this.pn_BottomLeft.TabIndex = 3;
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
            // pn_Right
            // 
            this.pn_Right.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Right.Location = new System.Drawing.Point(792, 0);
            this.pn_Right.Margin = new System.Windows.Forms.Padding(0);
            this.pn_Right.Name = "pn_Right";
            this.pn_Right.Size = new System.Drawing.Size(8, 412);
            this.pn_Right.TabIndex = 4;
            // 
            // pn_BottomRight
            // 
            this.pn_BottomRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_BottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_BottomRight.Location = new System.Drawing.Point(792, 412);
            this.pn_BottomRight.Margin = new System.Windows.Forms.Padding(0);
            this.pn_BottomRight.Name = "pn_BottomRight";
            this.pn_BottomRight.Size = new System.Drawing.Size(8, 8);
            this.pn_BottomRight.TabIndex = 5;
            // 
            // pn_Left
            // 
            this.pn_Left.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Left.Location = new System.Drawing.Point(0, 0);
            this.pn_Left.Margin = new System.Windows.Forms.Padding(0);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(8, 412);
            this.pn_Left.TabIndex = 6;
            // 
            // Folder_Contents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 250);
            this.Name = "Folder_Contents";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Folder_Contents";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Folder_Contents_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_Header.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColorDialog color_Dialog;
        private System.Windows.Forms.TableLayoutPanel panel_Header;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_ToggleFull;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel panel_Content;
        private System.Windows.Forms.Panel pn_Left;
        private System.Windows.Forms.Panel pn_BottomRight;
        private System.Windows.Forms.Panel pn_Right;
        private System.Windows.Forms.Panel pn_BottomLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_BottomBorder;
    }
}