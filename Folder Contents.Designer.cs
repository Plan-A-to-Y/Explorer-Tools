
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Folder_Contents));
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Content = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Content = new System.Windows.Forms.FlowLayoutPanel();
            this.tlp_Toolbar = new System.Windows.Forms.TableLayoutPanel();
            this.ts_FolderTools = new System.Windows.Forms.ToolStrip();
            this.tsb_File = new System.Windows.Forms.ToolStripButton();
            this.tsb_Edit = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_ShowFilters = new System.Windows.Forms.Button();
            this.tlp_Filters = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ShowTools = new System.Windows.Forms.Button();
            this.cb_FilterType = new System.Windows.Forms.ComboBox();
            this.flp_Filters = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_TopLeft = new System.Windows.Forms.Panel();
            this.pn_TopRight = new System.Windows.Forms.Panel();
            this.pn_LeftBorder = new System.Windows.Forms.Panel();
            this.pn_TopBorder = new System.Windows.Forms.Panel();
            this.pn_BottomRight = new System.Windows.Forms.Panel();
            this.tlp_Header = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_ToggleFull = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.tlp_FolderInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lb_FolderName = new System.Windows.Forms.Label();
            this.pb_FolderIcon = new System.Windows.Forms.PictureBox();
            this.pn_RightBorder = new System.Windows.Forms.Panel();
            this.pn_BottomLeft = new System.Windows.Forms.Panel();
            this.pn_BottomBorder = new System.Windows.Forms.Panel();
            this.color_Dialog = new System.Windows.Forms.ColorDialog();
            this.tlp_Main.SuspendLayout();
            this.tlp_Content.SuspendLayout();
            this.tlp_Toolbar.SuspendLayout();
            this.ts_FolderTools.SuspendLayout();
            this.tlp_Filters.SuspendLayout();
            this.tlp_Header.SuspendLayout();
            this.tlp_FolderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FolderIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 3;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp_Main.Controls.Add(this.tlp_Content, 1, 2);
            this.tlp_Main.Controls.Add(this.pn_TopLeft, 0, 0);
            this.tlp_Main.Controls.Add(this.pn_TopRight, 2, 0);
            this.tlp_Main.Controls.Add(this.pn_LeftBorder, 0, 1);
            this.tlp_Main.Controls.Add(this.pn_TopBorder, 1, 0);
            this.tlp_Main.Controls.Add(this.pn_BottomRight, 2, 3);
            this.tlp_Main.Controls.Add(this.tlp_Header, 1, 1);
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
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Main.Size = new System.Drawing.Size(800, 450);
            this.tlp_Main.TabIndex = 1;
            // 
            // tlp_Content
            // 
            this.tlp_Content.ColumnCount = 1;
            this.tlp_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Content.Controls.Add(this.panel_Content, 0, 2);
            this.tlp_Content.Controls.Add(this.tlp_Toolbar, 0, 0);
            this.tlp_Content.Controls.Add(this.tlp_Filters, 0, 1);
            this.tlp_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Content.Location = new System.Drawing.Point(8, 38);
            this.tlp_Content.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Content.Name = "tlp_Content";
            this.tlp_Content.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tlp_Content.RowCount = 3;
            this.tlp_Content.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Content.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Content.Size = new System.Drawing.Size(784, 404);
            this.tlp_Content.TabIndex = 9;
            // 
            // panel_Content
            // 
            this.panel_Content.AllowDrop = true;
            this.panel_Content.AutoScroll = true;
            this.panel_Content.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.panel_Content.AutoSize = true;
            this.panel_Content.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Content.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(0, 56);
            this.panel_Content.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Content.MinimumSize = new System.Drawing.Size(30, 30);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(784, 348);
            this.panel_Content.TabIndex = 10;
            this.panel_Content.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_Content_DragDrop);
            this.panel_Content.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_Content_DragEnter);
            this.panel_Content.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Content_Paint);
            // 
            // tlp_Toolbar
            // 
            this.tlp_Toolbar.ColumnCount = 2;
            this.tlp_Toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Toolbar.Controls.Add(this.ts_FolderTools, 0, 0);
            this.tlp_Toolbar.Controls.Add(this.btn_ShowFilters, 1, 0);
            this.tlp_Toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Toolbar.Location = new System.Drawing.Point(0, 2);
            this.tlp_Toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Toolbar.Name = "tlp_Toolbar";
            this.tlp_Toolbar.RowCount = 1;
            this.tlp_Toolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Toolbar.Size = new System.Drawing.Size(784, 20);
            this.tlp_Toolbar.TabIndex = 11;
            // 
            // ts_FolderTools
            // 
            this.ts_FolderTools.AutoSize = false;
            this.ts_FolderTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ts_FolderTools.GripMargin = new System.Windows.Forms.Padding(0);
            this.ts_FolderTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_FolderTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_File,
            this.tsb_Edit});
            this.ts_FolderTools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ts_FolderTools.Location = new System.Drawing.Point(0, 0);
            this.ts_FolderTools.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ts_FolderTools.MinimumSize = new System.Drawing.Size(0, 20);
            this.ts_FolderTools.Name = "ts_FolderTools";
            this.ts_FolderTools.Padding = new System.Windows.Forms.Padding(0);
            this.ts_FolderTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_FolderTools.Size = new System.Drawing.Size(677, 20);
            this.ts_FolderTools.Stretch = true;
            this.ts_FolderTools.TabIndex = 12;
            // 
            // tsb_File
            // 
            this.tsb_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_File.Image = ((System.Drawing.Image)(resources.GetObject("tsb_File.Image")));
            this.tsb_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_File.Name = "tsb_File";
            this.tsb_File.Size = new System.Drawing.Size(29, 19);
            this.tsb_File.Text = "File";
            // 
            // tsb_Edit
            // 
            this.tsb_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Edit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Edit.Image")));
            this.tsb_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Edit.Name = "tsb_Edit";
            this.tsb_Edit.Size = new System.Drawing.Size(41, 19);
            this.tsb_Edit.Text = "Sort";
            // 
            // btn_ShowFilters
            // 
            this.btn_ShowFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ShowFilters.FlatAppearance.BorderSize = 0;
            this.btn_ShowFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowFilters.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowFilters.Location = new System.Drawing.Point(677, 0);
            this.btn_ShowFilters.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_ShowFilters.MinimumSize = new System.Drawing.Size(0, 20);
            this.btn_ShowFilters.Name = "btn_ShowFilters";
            this.btn_ShowFilters.Size = new System.Drawing.Size(107, 20);
            this.btn_ShowFilters.TabIndex = 13;
            this.btn_ShowFilters.Text = "Show Filters";
            this.btn_ShowFilters.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ShowFilters.UseVisualStyleBackColor = true;
            this.btn_ShowFilters.Click += new System.EventHandler(this.btn_ShowFilters_Click);
            // 
            // tlp_Filters
            // 
            this.tlp_Filters.AutoSize = true;
            this.tlp_Filters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Filters.ColumnCount = 3;
            this.tlp_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Filters.Controls.Add(this.btn_ShowTools, 2, 0);
            this.tlp_Filters.Controls.Add(this.cb_FilterType, 0, 0);
            this.tlp_Filters.Controls.Add(this.flp_Filters, 1, 0);
            this.tlp_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Filters.Location = new System.Drawing.Point(0, 22);
            this.tlp_Filters.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tlp_Filters.MinimumSize = new System.Drawing.Size(0, 30);
            this.tlp_Filters.Name = "tlp_Filters";
            this.tlp_Filters.RowCount = 1;
            this.tlp_Filters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Filters.Size = new System.Drawing.Size(784, 32);
            this.tlp_Filters.TabIndex = 12;
            // 
            // btn_ShowTools
            // 
            this.btn_ShowTools.AutoSize = true;
            this.btn_ShowTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ShowTools.FlatAppearance.BorderSize = 0;
            this.btn_ShowTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowTools.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowTools.Location = new System.Drawing.Point(677, 0);
            this.btn_ShowTools.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_ShowTools.Name = "btn_ShowTools";
            this.btn_ShowTools.Size = new System.Drawing.Size(107, 30);
            this.btn_ShowTools.TabIndex = 14;
            this.btn_ShowTools.Text = "Hide Filters";
            this.btn_ShowTools.UseVisualStyleBackColor = true;
            this.btn_ShowTools.Click += new System.EventHandler(this.btn_ShowTools_Click);
            // 
            // cb_FilterType
            // 
            this.cb_FilterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_FilterType.FormattingEnabled = true;
            this.cb_FilterType.Location = new System.Drawing.Point(3, 3);
            this.cb_FilterType.Name = "cb_FilterType";
            this.cb_FilterType.Size = new System.Drawing.Size(94, 23);
            this.cb_FilterType.TabIndex = 0;
            this.cb_FilterType.SelectedIndexChanged += new System.EventHandler(this.cb_FilterType_SelectedIndexChanged);
            // 
            // flp_Filters
            // 
            this.flp_Filters.AutoScroll = true;
            this.flp_Filters.AutoSize = true;
            this.flp_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Filters.Location = new System.Drawing.Point(100, 0);
            this.flp_Filters.Margin = new System.Windows.Forms.Padding(0);
            this.flp_Filters.Name = "flp_Filters";
            this.flp_Filters.Size = new System.Drawing.Size(577, 32);
            this.flp_Filters.TabIndex = 15;
            this.flp_Filters.WrapContents = false;
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
            // tlp_Header
            // 
            this.tlp_Header.ColumnCount = 5;
            this.tlp_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Header.Controls.Add(this.btn_Minimize, 2, 0);
            this.tlp_Header.Controls.Add(this.btn_ToggleFull, 3, 0);
            this.tlp_Header.Controls.Add(this.btn_Close, 4, 0);
            this.tlp_Header.Controls.Add(this.btn_Edit, 0, 0);
            this.tlp_Header.Controls.Add(this.tlp_FolderInfo, 1, 0);
            this.tlp_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Header.Location = new System.Drawing.Point(8, 8);
            this.tlp_Header.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Header.Name = "tlp_Header";
            this.tlp_Header.RowCount = 1;
            this.tlp_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Header.Size = new System.Drawing.Size(784, 30);
            this.tlp_Header.TabIndex = 1;
            this.tlp_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseDown);
            this.tlp_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Folder_Contents_MouseMove);
            this.tlp_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseUp);
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
            // tlp_FolderInfo
            // 
            this.tlp_FolderInfo.ColumnCount = 3;
            this.tlp_FolderInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_FolderInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_FolderInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_FolderInfo.Controls.Add(this.lb_FolderName, 1, 0);
            this.tlp_FolderInfo.Controls.Add(this.pb_FolderIcon, 0, 0);
            this.tlp_FolderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_FolderInfo.Location = new System.Drawing.Point(30, 0);
            this.tlp_FolderInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_FolderInfo.Name = "tlp_FolderInfo";
            this.tlp_FolderInfo.RowCount = 1;
            this.tlp_FolderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_FolderInfo.Size = new System.Drawing.Size(664, 30);
            this.tlp_FolderInfo.TabIndex = 4;
            this.tlp_FolderInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseDown);
            this.tlp_FolderInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Folder_Contents_MouseMove);
            this.tlp_FolderInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseUp);
            // 
            // lb_FolderName
            // 
            this.lb_FolderName.AutoSize = true;
            this.lb_FolderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_FolderName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_FolderName.Location = new System.Drawing.Point(36, 0);
            this.lb_FolderName.Margin = new System.Windows.Forms.Padding(0);
            this.lb_FolderName.Name = "lb_FolderName";
            this.lb_FolderName.Size = new System.Drawing.Size(289, 30);
            this.lb_FolderName.TabIndex = 1;
            this.lb_FolderName.Text = "INSERT FOLDER NAME HERE";
            this.lb_FolderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_FolderName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseDown);
            this.lb_FolderName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Folder_Contents_MouseMove);
            this.lb_FolderName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseUp);
            // 
            // pb_FolderIcon
            // 
            this.pb_FolderIcon.BackColor = System.Drawing.Color.Transparent;
            this.pb_FolderIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_FolderIcon.InitialImage = global::Explorer_Tools.Properties.Resources.FolderTempIcon;
            this.pb_FolderIcon.Location = new System.Drawing.Point(3, 0);
            this.pb_FolderIcon.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pb_FolderIcon.Name = "pb_FolderIcon";
            this.pb_FolderIcon.Size = new System.Drawing.Size(30, 30);
            this.pb_FolderIcon.TabIndex = 0;
            this.pb_FolderIcon.TabStop = false;
            this.pb_FolderIcon.Click += new System.EventHandler(this.pb_FolderIcon_Click);
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
            this.pn_BottomBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_BottomBorder.Location = new System.Drawing.Point(8, 442);
            this.pn_BottomBorder.Margin = new System.Windows.Forms.Padding(0);
            this.pn_BottomBorder.Name = "pn_BottomBorder";
            this.pn_BottomBorder.Size = new System.Drawing.Size(784, 8);
            this.pn_BottomBorder.TabIndex = 2;
            this.pn_BottomBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_BottomBorder_Paint);
            this.pn_BottomBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.pn_BottomBorder.MouseLeave += new System.EventHandler(this.Resize_MouseLeave);
            this.pn_BottomBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.pn_BottomBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
            // 
            // color_Dialog
            // 
            this.color_Dialog.AnyColor = true;
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
            this.tlp_Content.ResumeLayout(false);
            this.tlp_Content.PerformLayout();
            this.tlp_Toolbar.ResumeLayout(false);
            this.ts_FolderTools.ResumeLayout(false);
            this.ts_FolderTools.PerformLayout();
            this.tlp_Filters.ResumeLayout(false);
            this.tlp_Filters.PerformLayout();
            this.tlp_Header.ResumeLayout(false);
            this.tlp_FolderInfo.ResumeLayout(false);
            this.tlp_FolderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FolderIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.ColorDialog color_Dialog;
        private System.Windows.Forms.TableLayoutPanel tlp_Header;
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
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.TableLayoutPanel tlp_FolderInfo;
        private System.Windows.Forms.PictureBox pb_FolderIcon;
        private System.Windows.Forms.Label lb_FolderName;
        private System.Windows.Forms.TableLayoutPanel tlp_Content;
        private System.Windows.Forms.FlowLayoutPanel panel_Content;
        private System.Windows.Forms.TableLayoutPanel tlp_Toolbar;
        private System.Windows.Forms.ToolStrip ts_FolderTools;
        private System.Windows.Forms.ToolStripButton tsb_File;
        private System.Windows.Forms.ToolStripDropDownButton tsb_Edit;
        private System.Windows.Forms.Button btn_ShowFilters;
        private System.Windows.Forms.TableLayoutPanel tlp_Filters;
        private System.Windows.Forms.Button btn_ShowTools;
        private System.Windows.Forms.ComboBox cb_FilterType;
        private System.Windows.Forms.FlowLayoutPanel flp_Filters;
    }
}