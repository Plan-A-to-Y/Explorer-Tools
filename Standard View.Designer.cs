
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
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ShowSidebar = new System.Windows.Forms.Button();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.tabs_Sidebar = new System.Windows.Forms.TabControl();
            this.tp_PLACEHOLDER = new System.Windows.Forms.TabPage();
            this.tp_Explorer = new System.Windows.Forms.TabPage();
            this.tp_Settings = new System.Windows.Forms.TabPage();
            this.tb_Tags = new System.Windows.Forms.TabPage();
            this.tp_Appearance = new System.Windows.Forms.TabPage();
            this.tlp_Appearance = new System.Windows.Forms.TableLayoutPanel();
            this.pn_EditBy = new System.Windows.Forms.Panel();
            this.rb_Tag = new System.Windows.Forms.RadioButton();
            this.rb_Category = new System.Windows.Forms.RadioButton();
            this.rb_Defaults = new System.Windows.Forms.RadioButton();
            this.lb_Edit = new System.Windows.Forms.Label();
            this.tlp_AppearanceContext = new System.Windows.Forms.TableLayoutPanel();
            this.lb_AppearanceContext = new System.Windows.Forms.Label();
            this.cb_CategoryTag = new System.Windows.Forms.ComboBox();
            this.gb_Icon = new System.Windows.Forms.GroupBox();
            this.tlp_Icon = new System.Windows.Forms.TableLayoutPanel();
            this.btn_BrowseForIcon = new System.Windows.Forms.Button();
            this.cb_Icons = new System.Windows.Forms.ComboBox();
            this.lb_UseExistingIcon = new System.Windows.Forms.Label();
            this.pb_IconPreview = new System.Windows.Forms.PictureBox();
            this.gb_Presets = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pn_ColorText = new System.Windows.Forms.Panel();
            this.pn_ColorAccent = new System.Windows.Forms.Panel();
            this.pn_ColorConent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_ColorHeader = new System.Windows.Forms.Panel();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.cb_Presets = new System.Windows.Forms.ComboBox();
            this.gb_Colors = new System.Windows.Forms.GroupBox();
            this.rb_Presets = new System.Windows.Forms.RadioButton();
            this.tlp_Main.SuspendLayout();
            this.tabs_Sidebar.SuspendLayout();
            this.tp_Appearance.SuspendLayout();
            this.tlp_Appearance.SuspendLayout();
            this.pn_EditBy.SuspendLayout();
            this.tlp_AppearanceContext.SuspendLayout();
            this.gb_Icon.SuspendLayout();
            this.tlp_Icon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconPreview)).BeginInit();
            this.gb_Presets.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 3;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.btn_ShowSidebar, 1, 0);
            this.tlp_Main.Controls.Add(this.pn_Main, 2, 0);
            this.tlp_Main.Controls.Add(this.tabs_Sidebar, 0, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 1;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(916, 416);
            this.tlp_Main.TabIndex = 9;
            // 
            // btn_ShowSidebar
            // 
            this.btn_ShowSidebar.Location = new System.Drawing.Point(456, 3);
            this.btn_ShowSidebar.MinimumSize = new System.Drawing.Size(30, 45);
            this.btn_ShowSidebar.Name = "btn_ShowSidebar";
            this.btn_ShowSidebar.Size = new System.Drawing.Size(30, 45);
            this.btn_ShowSidebar.TabIndex = 0;
            this.btn_ShowSidebar.Text = "→";
            this.btn_ShowSidebar.UseVisualStyleBackColor = true;
            this.btn_ShowSidebar.Click += new System.EventHandler(this.btn_ShowSidebar_Click);
            // 
            // pn_Main
            // 
            this.pn_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Main.Location = new System.Drawing.Point(489, 0);
            this.pn_Main.Margin = new System.Windows.Forms.Padding(0);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(427, 416);
            this.pn_Main.TabIndex = 7;
            // 
            // tabs_Sidebar
            // 
            this.tabs_Sidebar.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabs_Sidebar.Controls.Add(this.tp_PLACEHOLDER);
            this.tabs_Sidebar.Controls.Add(this.tp_Explorer);
            this.tabs_Sidebar.Controls.Add(this.tp_Settings);
            this.tabs_Sidebar.Controls.Add(this.tb_Tags);
            this.tabs_Sidebar.Controls.Add(this.tp_Appearance);
            this.tabs_Sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs_Sidebar.HotTrack = true;
            this.tabs_Sidebar.ItemSize = new System.Drawing.Size(10, 25);
            this.tabs_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.tabs_Sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.tabs_Sidebar.Multiline = true;
            this.tabs_Sidebar.Name = "tabs_Sidebar";
            this.tabs_Sidebar.Padding = new System.Drawing.Point(0, 0);
            this.tabs_Sidebar.SelectedIndex = 0;
            this.tabs_Sidebar.Size = new System.Drawing.Size(453, 416);
            this.tabs_Sidebar.TabIndex = 8;
            this.tabs_Sidebar.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabs_Sidebar_Selecting);
            // 
            // tp_PLACEHOLDER
            // 
            this.tp_PLACEHOLDER.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tp_PLACEHOLDER.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tp_PLACEHOLDER.Location = new System.Drawing.Point(4, 4);
            this.tp_PLACEHOLDER.Margin = new System.Windows.Forms.Padding(0);
            this.tp_PLACEHOLDER.Name = "tp_PLACEHOLDER";
            this.tp_PLACEHOLDER.Size = new System.Drawing.Size(420, 408);
            this.tp_PLACEHOLDER.TabIndex = 2;
            this.tp_PLACEHOLDER.Text = "↓";
            // 
            // tp_Explorer
            // 
            this.tp_Explorer.Location = new System.Drawing.Point(4, 4);
            this.tp_Explorer.Margin = new System.Windows.Forms.Padding(2);
            this.tp_Explorer.Name = "tp_Explorer";
            this.tp_Explorer.Size = new System.Drawing.Size(420, 408);
            this.tp_Explorer.TabIndex = 0;
            this.tp_Explorer.Text = "Folder Browser";
            this.tp_Explorer.UseVisualStyleBackColor = true;
            // 
            // tp_Settings
            // 
            this.tp_Settings.Location = new System.Drawing.Point(4, 4);
            this.tp_Settings.Name = "tp_Settings";
            this.tp_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Settings.Size = new System.Drawing.Size(420, 408);
            this.tp_Settings.TabIndex = 1;
            this.tp_Settings.Text = "Settings";
            this.tp_Settings.UseVisualStyleBackColor = true;
            // 
            // tb_Tags
            // 
            this.tb_Tags.Location = new System.Drawing.Point(4, 4);
            this.tb_Tags.Name = "tb_Tags";
            this.tb_Tags.Size = new System.Drawing.Size(420, 408);
            this.tb_Tags.TabIndex = 4;
            this.tb_Tags.Text = "Tags";
            this.tb_Tags.UseVisualStyleBackColor = true;
            // 
            // tp_Appearance
            // 
            this.tp_Appearance.Controls.Add(this.tlp_Appearance);
            this.tp_Appearance.Location = new System.Drawing.Point(4, 4);
            this.tp_Appearance.Name = "tp_Appearance";
            this.tp_Appearance.Size = new System.Drawing.Size(420, 408);
            this.tp_Appearance.TabIndex = 3;
            this.tp_Appearance.Text = "Appearance";
            this.tp_Appearance.UseVisualStyleBackColor = true;
            // 
            // tlp_Appearance
            // 
            this.tlp_Appearance.ColumnCount = 2;
            this.tlp_Appearance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Appearance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Appearance.Controls.Add(this.pn_EditBy, 0, 1);
            this.tlp_Appearance.Controls.Add(this.lb_Edit, 0, 0);
            this.tlp_Appearance.Controls.Add(this.tlp_AppearanceContext, 0, 2);
            this.tlp_Appearance.Controls.Add(this.gb_Icon, 0, 4);
            this.tlp_Appearance.Controls.Add(this.gb_Presets, 0, 3);
            this.tlp_Appearance.Controls.Add(this.gb_Colors, 1, 3);
            this.tlp_Appearance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Appearance.Location = new System.Drawing.Point(0, 0);
            this.tlp_Appearance.Name = "tlp_Appearance";
            this.tlp_Appearance.RowCount = 6;
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Appearance.Size = new System.Drawing.Size(420, 408);
            this.tlp_Appearance.TabIndex = 1;
            // 
            // pn_EditBy
            // 
            this.pn_EditBy.AutoSize = true;
            this.pn_EditBy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Appearance.SetColumnSpan(this.pn_EditBy, 2);
            this.pn_EditBy.Controls.Add(this.rb_Presets);
            this.pn_EditBy.Controls.Add(this.rb_Tag);
            this.pn_EditBy.Controls.Add(this.rb_Category);
            this.pn_EditBy.Controls.Add(this.rb_Defaults);
            this.pn_EditBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_EditBy.Location = new System.Drawing.Point(0, 15);
            this.pn_EditBy.Margin = new System.Windows.Forms.Padding(0);
            this.pn_EditBy.Name = "pn_EditBy";
            this.pn_EditBy.Size = new System.Drawing.Size(420, 26);
            this.pn_EditBy.TabIndex = 0;
            // 
            // rb_Tag
            // 
            this.rb_Tag.AutoSize = true;
            this.rb_Tag.Location = new System.Drawing.Point(158, 4);
            this.rb_Tag.Name = "rb_Tag";
            this.rb_Tag.Size = new System.Drawing.Size(43, 19);
            this.rb_Tag.TabIndex = 2;
            this.rb_Tag.Text = "Tag";
            this.rb_Tag.UseVisualStyleBackColor = true;
            this.rb_Tag.CheckedChanged += new System.EventHandler(this.rb_Tag_CheckedChanged);
            // 
            // rb_Category
            // 
            this.rb_Category.AutoSize = true;
            this.rb_Category.Location = new System.Drawing.Point(83, 4);
            this.rb_Category.Name = "rb_Category";
            this.rb_Category.Size = new System.Drawing.Size(73, 19);
            this.rb_Category.TabIndex = 1;
            this.rb_Category.Text = "Category";
            this.rb_Category.UseVisualStyleBackColor = true;
            this.rb_Category.CheckedChanged += new System.EventHandler(this.rb_Category_CheckedChanged);
            // 
            // rb_Defaults
            // 
            this.rb_Defaults.AutoSize = true;
            this.rb_Defaults.Checked = true;
            this.rb_Defaults.Location = new System.Drawing.Point(9, 4);
            this.rb_Defaults.Name = "rb_Defaults";
            this.rb_Defaults.Size = new System.Drawing.Size(68, 19);
            this.rb_Defaults.TabIndex = 0;
            this.rb_Defaults.TabStop = true;
            this.rb_Defaults.Text = "Defaults";
            this.rb_Defaults.UseVisualStyleBackColor = true;
            this.rb_Defaults.CheckedChanged += new System.EventHandler(this.rb_Defaults_CheckedChanged);
            // 
            // lb_Edit
            // 
            this.lb_Edit.AutoSize = true;
            this.lb_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Edit.Location = new System.Drawing.Point(0, 0);
            this.lb_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Edit.Name = "lb_Edit";
            this.lb_Edit.Size = new System.Drawing.Size(210, 15);
            this.lb_Edit.TabIndex = 1;
            this.lb_Edit.Text = "Edit...";
            this.lb_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_AppearanceContext
            // 
            this.tlp_AppearanceContext.AutoSize = true;
            this.tlp_AppearanceContext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_AppearanceContext.ColumnCount = 1;
            this.tlp_Appearance.SetColumnSpan(this.tlp_AppearanceContext, 2);
            this.tlp_AppearanceContext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_AppearanceContext.Controls.Add(this.lb_AppearanceContext, 0, 0);
            this.tlp_AppearanceContext.Controls.Add(this.cb_CategoryTag, 0, 1);
            this.tlp_AppearanceContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_AppearanceContext.Location = new System.Drawing.Point(0, 41);
            this.tlp_AppearanceContext.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_AppearanceContext.Name = "tlp_AppearanceContext";
            this.tlp_AppearanceContext.RowCount = 2;
            this.tlp_AppearanceContext.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_AppearanceContext.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_AppearanceContext.Size = new System.Drawing.Size(420, 48);
            this.tlp_AppearanceContext.TabIndex = 2;
            // 
            // lb_AppearanceContext
            // 
            this.lb_AppearanceContext.AutoSize = true;
            this.lb_AppearanceContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_AppearanceContext.Location = new System.Drawing.Point(0, 0);
            this.lb_AppearanceContext.Margin = new System.Windows.Forms.Padding(0);
            this.lb_AppearanceContext.Name = "lb_AppearanceContext";
            this.lb_AppearanceContext.Size = new System.Drawing.Size(420, 15);
            this.lb_AppearanceContext.TabIndex = 2;
            this.lb_AppearanceContext.Text = "Category:";
            this.lb_AppearanceContext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_CategoryTag
            // 
            this.cb_CategoryTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_CategoryTag.FormattingEnabled = true;
            this.cb_CategoryTag.Location = new System.Drawing.Point(3, 20);
            this.cb_CategoryTag.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_CategoryTag.Name = "cb_CategoryTag";
            this.cb_CategoryTag.Size = new System.Drawing.Size(414, 23);
            this.cb_CategoryTag.TabIndex = 1;
            // 
            // gb_Icon
            // 
            this.gb_Icon.Controls.Add(this.tlp_Icon);
            this.gb_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Icon.Location = new System.Drawing.Point(0, 245);
            this.gb_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.gb_Icon.Name = "gb_Icon";
            this.gb_Icon.Padding = new System.Windows.Forms.Padding(0);
            this.gb_Icon.Size = new System.Drawing.Size(210, 144);
            this.gb_Icon.TabIndex = 3;
            this.gb_Icon.TabStop = false;
            this.gb_Icon.Text = "Icon";
            // 
            // tlp_Icon
            // 
            this.tlp_Icon.ColumnCount = 2;
            this.tlp_Icon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Icon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Icon.Controls.Add(this.btn_BrowseForIcon, 1, 1);
            this.tlp_Icon.Controls.Add(this.cb_Icons, 0, 2);
            this.tlp_Icon.Controls.Add(this.lb_UseExistingIcon, 0, 1);
            this.tlp_Icon.Controls.Add(this.pb_IconPreview, 0, 0);
            this.tlp_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Icon.Location = new System.Drawing.Point(0, 16);
            this.tlp_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Icon.Name = "tlp_Icon";
            this.tlp_Icon.RowCount = 3;
            this.tlp_Icon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Icon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Icon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Icon.Size = new System.Drawing.Size(210, 128);
            this.tlp_Icon.TabIndex = 0;
            // 
            // btn_BrowseForIcon
            // 
            this.btn_BrowseForIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_BrowseForIcon.Location = new System.Drawing.Point(108, 87);
            this.btn_BrowseForIcon.Name = "btn_BrowseForIcon";
            this.tlp_Icon.SetRowSpan(this.btn_BrowseForIcon, 2);
            this.btn_BrowseForIcon.Size = new System.Drawing.Size(99, 38);
            this.btn_BrowseForIcon.TabIndex = 0;
            this.btn_BrowseForIcon.Text = "Browse...";
            this.btn_BrowseForIcon.UseVisualStyleBackColor = true;
            // 
            // cb_Icons
            // 
            this.cb_Icons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Icons.FormattingEnabled = true;
            this.cb_Icons.Location = new System.Drawing.Point(3, 102);
            this.cb_Icons.Name = "cb_Icons";
            this.cb_Icons.Size = new System.Drawing.Size(99, 23);
            this.cb_Icons.TabIndex = 1;
            // 
            // lb_UseExistingIcon
            // 
            this.lb_UseExistingIcon.AutoSize = true;
            this.lb_UseExistingIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_UseExistingIcon.Location = new System.Drawing.Point(3, 84);
            this.lb_UseExistingIcon.MinimumSize = new System.Drawing.Size(15, 0);
            this.lb_UseExistingIcon.Name = "lb_UseExistingIcon";
            this.lb_UseExistingIcon.Size = new System.Drawing.Size(99, 15);
            this.lb_UseExistingIcon.TabIndex = 2;
            this.lb_UseExistingIcon.Text = "Existing Icons:";
            // 
            // pb_IconPreview
            // 
            this.tlp_Icon.SetColumnSpan(this.pb_IconPreview, 2);
            this.pb_IconPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_IconPreview.Image = global::Explorer_Tools.Properties.Resources.FolderTempIcon;
            this.pb_IconPreview.InitialImage = global::Explorer_Tools.Properties.Resources.FolderTempIcon;
            this.pb_IconPreview.Location = new System.Drawing.Point(3, 3);
            this.pb_IconPreview.Name = "pb_IconPreview";
            this.pb_IconPreview.Size = new System.Drawing.Size(204, 78);
            this.pb_IconPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_IconPreview.TabIndex = 3;
            this.pb_IconPreview.TabStop = false;
            // 
            // gb_Presets
            // 
            this.gb_Presets.AutoSize = true;
            this.gb_Presets.Controls.Add(this.tableLayoutPanel1);
            this.gb_Presets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Presets.Location = new System.Drawing.Point(0, 89);
            this.gb_Presets.Margin = new System.Windows.Forms.Padding(0);
            this.gb_Presets.Name = "gb_Presets";
            this.gb_Presets.Padding = new System.Windows.Forms.Padding(0);
            this.gb_Presets.Size = new System.Drawing.Size(210, 156);
            this.gb_Presets.TabIndex = 4;
            this.gb_Presets.TabStop = false;
            this.gb_Presets.Text = "Presets";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Preview, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Apply, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_Presets, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pn_ColorText, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.pn_ColorAccent, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.pn_ColorConent, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.pn_ColorHeader, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 80);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // pn_ColorText
            // 
            this.pn_ColorText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ColorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ColorText.Location = new System.Drawing.Point(160, 5);
            this.pn_ColorText.Margin = new System.Windows.Forms.Padding(5);
            this.pn_ColorText.Name = "pn_ColorText";
            this.pn_ColorText.Size = new System.Drawing.Size(40, 40);
            this.pn_ColorText.TabIndex = 7;
            // 
            // pn_ColorAccent
            // 
            this.pn_ColorAccent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ColorAccent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ColorAccent.Location = new System.Drawing.Point(110, 5);
            this.pn_ColorAccent.Margin = new System.Windows.Forms.Padding(5);
            this.pn_ColorAccent.Name = "pn_ColorAccent";
            this.pn_ColorAccent.Size = new System.Drawing.Size(40, 40);
            this.pn_ColorAccent.TabIndex = 6;
            // 
            // pn_ColorConent
            // 
            this.pn_ColorConent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ColorConent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ColorConent.Location = new System.Drawing.Point(60, 5);
            this.pn_ColorConent.Margin = new System.Windows.Forms.Padding(5);
            this.pn_ColorConent.Name = "pn_ColorConent";
            this.pn_ColorConent.Size = new System.Drawing.Size(40, 40);
            this.pn_ColorConent.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Header";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Content";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(108, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Accent";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(158, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Text";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_ColorHeader
            // 
            this.pn_ColorHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ColorHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ColorHeader.Location = new System.Drawing.Point(10, 5);
            this.pn_ColorHeader.Margin = new System.Windows.Forms.Padding(5);
            this.pn_ColorHeader.Name = "pn_ColorHeader";
            this.pn_ColorHeader.Size = new System.Drawing.Size(40, 40);
            this.pn_ColorHeader.TabIndex = 4;
            // 
            // btn_Preview
            // 
            this.btn_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Preview.Location = new System.Drawing.Point(3, 113);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(99, 24);
            this.btn_Preview.TabIndex = 0;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = true;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Apply.Location = new System.Drawing.Point(108, 113);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(99, 24);
            this.btn_Apply.TabIndex = 1;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            // 
            // cb_Presets
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cb_Presets, 2);
            this.cb_Presets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Presets.FormattingEnabled = true;
            this.cb_Presets.Location = new System.Drawing.Point(3, 83);
            this.cb_Presets.Name = "cb_Presets";
            this.cb_Presets.Size = new System.Drawing.Size(204, 23);
            this.cb_Presets.TabIndex = 2;
            // 
            // gb_Colors
            // 
            this.gb_Colors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Colors.Location = new System.Drawing.Point(213, 92);
            this.gb_Colors.Name = "gb_Colors";
            this.tlp_Appearance.SetRowSpan(this.gb_Colors, 2);
            this.gb_Colors.Size = new System.Drawing.Size(204, 294);
            this.gb_Colors.TabIndex = 5;
            this.gb_Colors.TabStop = false;
            this.gb_Colors.Text = "Colors";
            // 
            // rb_Presets
            // 
            this.rb_Presets.AutoSize = true;
            this.rb_Presets.Location = new System.Drawing.Point(207, 4);
            this.rb_Presets.Name = "rb_Presets";
            this.rb_Presets.Size = new System.Drawing.Size(62, 19);
            this.rb_Presets.TabIndex = 3;
            this.rb_Presets.Text = "Presets";
            this.rb_Presets.UseVisualStyleBackColor = true;
            this.rb_Presets.CheckedChanged += new System.EventHandler(this.rb_Presets_CheckedChanged);
            // 
            // form_StandardView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(916, 416);
            this.Controls.Add(this.tlp_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "form_StandardView";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.folderContents_SizeChanged);
            this.tlp_Main.ResumeLayout(false);
            this.tabs_Sidebar.ResumeLayout(false);
            this.tp_Appearance.ResumeLayout(false);
            this.tlp_Appearance.ResumeLayout(false);
            this.tlp_Appearance.PerformLayout();
            this.pn_EditBy.ResumeLayout(false);
            this.pn_EditBy.PerformLayout();
            this.tlp_AppearanceContext.ResumeLayout(false);
            this.tlp_AppearanceContext.PerformLayout();
            this.gb_Icon.ResumeLayout(false);
            this.tlp_Icon.ResumeLayout(false);
            this.tlp_Icon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconPreview)).EndInit();
            this.gb_Presets.ResumeLayout(false);
            this.gb_Presets.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.Panel pn_Main;
        private System.Windows.Forms.TabControl tabs_Sidebar;
        private System.Windows.Forms.TabPage tp_Explorer;
        private System.Windows.Forms.TabPage tp_Settings;
        private System.Windows.Forms.TabPage tp_PLACEHOLDER;
        private System.Windows.Forms.Button btn_ShowSidebar;
        private System.Windows.Forms.TabPage tb_Tags;
        private System.Windows.Forms.TabPage tp_Appearance;
        private System.Windows.Forms.TableLayoutPanel tlp_Appearance;
        private System.Windows.Forms.Panel pn_EditBy;
        private System.Windows.Forms.RadioButton rb_Tag;
        private System.Windows.Forms.RadioButton rb_Category;
        private System.Windows.Forms.RadioButton rb_Defaults;
        private System.Windows.Forms.Label lb_Edit;
        private System.Windows.Forms.TableLayoutPanel tlp_AppearanceContext;
        private System.Windows.Forms.ComboBox cb_CategoryTag;
        private System.Windows.Forms.GroupBox gb_Icon;
        private System.Windows.Forms.TableLayoutPanel tlp_Icon;
        private System.Windows.Forms.Button btn_BrowseForIcon;
        private System.Windows.Forms.ComboBox cb_Icons;
        private System.Windows.Forms.Label lb_UseExistingIcon;
        private System.Windows.Forms.PictureBox pb_IconPreview;
        private System.Windows.Forms.Label lb_AppearanceContext;
        private System.Windows.Forms.GroupBox gb_Presets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pn_ColorText;
        private System.Windows.Forms.Panel pn_ColorAccent;
        private System.Windows.Forms.Panel pn_ColorConent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pn_ColorHeader;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.ComboBox cb_Presets;
        private System.Windows.Forms.GroupBox gb_Colors;
        private System.Windows.Forms.RadioButton rb_Presets;
    }
}

