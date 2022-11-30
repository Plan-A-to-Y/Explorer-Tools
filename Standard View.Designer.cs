
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
            this.rb_Presets = new System.Windows.Forms.RadioButton();
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
            this.tlp_PresetsBox = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_PresetIcons = new System.Windows.Forms.TableLayoutPanel();
            this.lb_CL_T = new System.Windows.Forms.Label();
            this.lb_CL_S = new System.Windows.Forms.Label();
            this.lb_CL_F = new System.Windows.Forms.Label();
            this.lb_CL_B = new System.Windows.Forms.Label();
            this.pn_ColorF = new System.Windows.Forms.Panel();
            this.pn_ColorB = new System.Windows.Forms.Panel();
            this.pn_ColorT = new System.Windows.Forms.Panel();
            this.pn_ColorS = new System.Windows.Forms.Panel();
            this.pn_ColorP = new System.Windows.Forms.Panel();
            this.lb_CL_P = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.cb_Presets = new System.Windows.Forms.ComboBox();
            this.cb_Preview = new System.Windows.Forms.CheckBox();
            this.gb_Colors = new System.Windows.Forms.GroupBox();
            this.tlp_ColorSliders = new System.Windows.Forms.TableLayoutPanel();
            this.cs_F = new Explorer_Tools.ColorSlider();
            this.cs_B = new Explorer_Tools.ColorSlider();
            this.cs_T = new Explorer_Tools.ColorSlider();
            this.cs_S = new Explorer_Tools.ColorSlider();
            this.cs_P = new Explorer_Tools.ColorSlider();
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
            this.tlp_PresetsBox.SuspendLayout();
            this.tlp_PresetIcons.SuspendLayout();
            this.gb_Colors.SuspendLayout();
            this.tlp_ColorSliders.SuspendLayout();
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
            this.tlp_Main.Size = new System.Drawing.Size(886, 833);
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
            this.pn_Main.Size = new System.Drawing.Size(397, 833);
            this.pn_Main.TabIndex = 7;
            this.pn_Main.Tag = "Back:B";
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
            this.tabs_Sidebar.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabs_Sidebar.HotTrack = true;
            this.tabs_Sidebar.ItemSize = new System.Drawing.Size(10, 25);
            this.tabs_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.tabs_Sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.tabs_Sidebar.Multiline = true;
            this.tabs_Sidebar.Name = "tabs_Sidebar";
            this.tabs_Sidebar.Padding = new System.Drawing.Point(0, 0);
            this.tabs_Sidebar.SelectedIndex = 0;
            this.tabs_Sidebar.Size = new System.Drawing.Size(453, 833);
            this.tabs_Sidebar.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabs_Sidebar.TabIndex = 8;
            this.tabs_Sidebar.Tag = "TabHeader:P";
            this.tabs_Sidebar.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabs_Sidebar_Selecting);
            // 
            // tp_PLACEHOLDER
            // 
            this.tp_PLACEHOLDER.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tp_PLACEHOLDER.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tp_PLACEHOLDER.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tp_PLACEHOLDER.Location = new System.Drawing.Point(4, 4);
            this.tp_PLACEHOLDER.Margin = new System.Windows.Forms.Padding(0);
            this.tp_PLACEHOLDER.Name = "tp_PLACEHOLDER";
            this.tp_PLACEHOLDER.Size = new System.Drawing.Size(420, 825);
            this.tp_PLACEHOLDER.TabIndex = 2;
            this.tp_PLACEHOLDER.Text = "↓";
            // 
            // tp_Explorer
            // 
            this.tp_Explorer.BackColor = System.Drawing.Color.Transparent;
            this.tp_Explorer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tp_Explorer.Location = new System.Drawing.Point(4, 4);
            this.tp_Explorer.Margin = new System.Windows.Forms.Padding(2);
            this.tp_Explorer.Name = "tp_Explorer";
            this.tp_Explorer.Size = new System.Drawing.Size(420, 825);
            this.tp_Explorer.TabIndex = 0;
            this.tp_Explorer.Text = "Folder Browser";
            // 
            // tp_Settings
            // 
            this.tp_Settings.Location = new System.Drawing.Point(4, 4);
            this.tp_Settings.Name = "tp_Settings";
            this.tp_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Settings.Size = new System.Drawing.Size(420, 825);
            this.tp_Settings.TabIndex = 1;
            this.tp_Settings.Text = "Settings";
            this.tp_Settings.UseVisualStyleBackColor = true;
            // 
            // tb_Tags
            // 
            this.tb_Tags.Location = new System.Drawing.Point(4, 4);
            this.tb_Tags.Name = "tb_Tags";
            this.tb_Tags.Size = new System.Drawing.Size(420, 825);
            this.tb_Tags.TabIndex = 4;
            this.tb_Tags.Text = "Tags";
            this.tb_Tags.UseVisualStyleBackColor = true;
            // 
            // tp_Appearance
            // 
            this.tp_Appearance.Controls.Add(this.tlp_Appearance);
            this.tp_Appearance.Location = new System.Drawing.Point(4, 4);
            this.tp_Appearance.Name = "tp_Appearance";
            this.tp_Appearance.Size = new System.Drawing.Size(420, 825);
            this.tp_Appearance.TabIndex = 3;
            this.tp_Appearance.Text = "Appearance";
            this.tp_Appearance.UseVisualStyleBackColor = true;
            // 
            // tlp_Appearance
            // 
            this.tlp_Appearance.ColumnCount = 2;
            this.tlp_Appearance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlp_Appearance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Appearance.Controls.Add(this.pn_EditBy, 0, 1);
            this.tlp_Appearance.Controls.Add(this.lb_Edit, 0, 0);
            this.tlp_Appearance.Controls.Add(this.tlp_AppearanceContext, 0, 2);
            this.tlp_Appearance.Controls.Add(this.gb_Icon, 0, 4);
            this.tlp_Appearance.Controls.Add(this.gb_Presets, 0, 3);
            this.tlp_Appearance.Controls.Add(this.gb_Colors, 1, 3);
            this.tlp_Appearance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Appearance.Location = new System.Drawing.Point(0, 0);
            this.tlp_Appearance.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Appearance.Name = "tlp_Appearance";
            this.tlp_Appearance.RowCount = 6;
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Appearance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Appearance.Size = new System.Drawing.Size(420, 825);
            this.tlp_Appearance.TabIndex = 1;
            this.tlp_Appearance.Tag = "Back:B";
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
            // rb_Presets
            // 
            this.rb_Presets.AutoSize = true;
            this.rb_Presets.Location = new System.Drawing.Point(207, 4);
            this.rb_Presets.Name = "rb_Presets";
            this.rb_Presets.Size = new System.Drawing.Size(62, 19);
            this.rb_Presets.TabIndex = 3;
            this.rb_Presets.Tag = "Fore:F";
            this.rb_Presets.Text = "Presets";
            this.rb_Presets.UseVisualStyleBackColor = true;
            this.rb_Presets.CheckedChanged += new System.EventHandler(this.rb_Presets_CheckedChanged);
            // 
            // rb_Tag
            // 
            this.rb_Tag.AutoSize = true;
            this.rb_Tag.Location = new System.Drawing.Point(158, 4);
            this.rb_Tag.Name = "rb_Tag";
            this.rb_Tag.Size = new System.Drawing.Size(43, 19);
            this.rb_Tag.TabIndex = 2;
            this.rb_Tag.Tag = "Fore:F";
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
            this.rb_Category.Tag = "Fore:F";
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
            this.rb_Defaults.Tag = "Fore:F";
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
            this.lb_Edit.Size = new System.Drawing.Size(170, 15);
            this.lb_Edit.TabIndex = 1;
            this.lb_Edit.Tag = "Back:B Fore:F";
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
            this.lb_AppearanceContext.Tag = "Back:B Fore:F";
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
            this.gb_Icon.Size = new System.Drawing.Size(170, 144);
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
            this.tlp_Icon.Size = new System.Drawing.Size(170, 128);
            this.tlp_Icon.TabIndex = 0;
            // 
            // btn_BrowseForIcon
            // 
            this.btn_BrowseForIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_BrowseForIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BrowseForIcon.Location = new System.Drawing.Point(88, 72);
            this.btn_BrowseForIcon.Name = "btn_BrowseForIcon";
            this.tlp_Icon.SetRowSpan(this.btn_BrowseForIcon, 2);
            this.btn_BrowseForIcon.Size = new System.Drawing.Size(79, 53);
            this.btn_BrowseForIcon.TabIndex = 0;
            this.btn_BrowseForIcon.Tag = "Fore:F Back:B BtnBorder:T";
            this.btn_BrowseForIcon.Text = "Browse...";
            this.btn_BrowseForIcon.UseVisualStyleBackColor = true;
            // 
            // cb_Icons
            // 
            this.cb_Icons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Icons.FormattingEnabled = true;
            this.cb_Icons.Location = new System.Drawing.Point(3, 102);
            this.cb_Icons.Name = "cb_Icons";
            this.cb_Icons.Size = new System.Drawing.Size(79, 23);
            this.cb_Icons.TabIndex = 1;
            this.cb_Icons.SelectionChangeCommitted += new System.EventHandler(this.cb_Icons_SelectionChangeCommitted);
            // 
            // lb_UseExistingIcon
            // 
            this.lb_UseExistingIcon.AutoSize = true;
            this.lb_UseExistingIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_UseExistingIcon.Location = new System.Drawing.Point(3, 69);
            this.lb_UseExistingIcon.MinimumSize = new System.Drawing.Size(15, 0);
            this.lb_UseExistingIcon.Name = "lb_UseExistingIcon";
            this.lb_UseExistingIcon.Size = new System.Drawing.Size(79, 30);
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
            this.pb_IconPreview.Size = new System.Drawing.Size(164, 63);
            this.pb_IconPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_IconPreview.TabIndex = 3;
            this.pb_IconPreview.TabStop = false;
            // 
            // gb_Presets
            // 
            this.gb_Presets.AutoSize = true;
            this.gb_Presets.Controls.Add(this.tlp_PresetsBox);
            this.gb_Presets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Presets.Location = new System.Drawing.Point(0, 89);
            this.gb_Presets.Margin = new System.Windows.Forms.Padding(0);
            this.gb_Presets.Name = "gb_Presets";
            this.gb_Presets.Padding = new System.Windows.Forms.Padding(0);
            this.gb_Presets.Size = new System.Drawing.Size(170, 156);
            this.gb_Presets.TabIndex = 4;
            this.gb_Presets.TabStop = false;
            this.gb_Presets.Tag = "Back:B Fore:F";
            this.gb_Presets.Text = "Presets";
            // 
            // tlp_PresetsBox
            // 
            this.tlp_PresetsBox.AutoSize = true;
            this.tlp_PresetsBox.ColumnCount = 2;
            this.tlp_PresetsBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PresetsBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PresetsBox.Controls.Add(this.tlp_PresetIcons, 0, 0);
            this.tlp_PresetsBox.Controls.Add(this.btn_Apply, 1, 2);
            this.tlp_PresetsBox.Controls.Add(this.cb_Presets, 0, 1);
            this.tlp_PresetsBox.Controls.Add(this.cb_Preview, 0, 2);
            this.tlp_PresetsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_PresetsBox.Location = new System.Drawing.Point(0, 16);
            this.tlp_PresetsBox.Name = "tlp_PresetsBox";
            this.tlp_PresetsBox.RowCount = 3;
            this.tlp_PresetsBox.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_PresetsBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_PresetsBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_PresetsBox.Size = new System.Drawing.Size(170, 140);
            this.tlp_PresetsBox.TabIndex = 0;
            // 
            // tlp_PresetIcons
            // 
            this.tlp_PresetIcons.AutoSize = true;
            this.tlp_PresetIcons.ColumnCount = 7;
            this.tlp_PresetsBox.SetColumnSpan(this.tlp_PresetIcons, 2);
            this.tlp_PresetIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PresetIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_PresetIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_PresetIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_PresetIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_PresetIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_PresetIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PresetIcons.Controls.Add(this.lb_CL_T, 2, 2);
            this.tlp_PresetIcons.Controls.Add(this.lb_CL_S, 2, 2);
            this.tlp_PresetIcons.Controls.Add(this.lb_CL_F, 2, 2);
            this.tlp_PresetIcons.Controls.Add(this.lb_CL_B, 2, 2);
            this.tlp_PresetIcons.Controls.Add(this.pn_ColorF, 5, 1);
            this.tlp_PresetIcons.Controls.Add(this.pn_ColorB, 4, 1);
            this.tlp_PresetIcons.Controls.Add(this.pn_ColorT, 3, 1);
            this.tlp_PresetIcons.Controls.Add(this.pn_ColorS, 2, 1);
            this.tlp_PresetIcons.Controls.Add(this.pn_ColorP, 1, 1);
            this.tlp_PresetIcons.Controls.Add(this.lb_CL_P, 1, 2);
            this.tlp_PresetIcons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_PresetIcons.Location = new System.Drawing.Point(0, 0);
            this.tlp_PresetIcons.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_PresetIcons.Name = "tlp_PresetIcons";
            this.tlp_PresetIcons.RowCount = 4;
            this.tlp_PresetIcons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PresetIcons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_PresetIcons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_PresetIcons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PresetIcons.Size = new System.Drawing.Size(170, 80);
            this.tlp_PresetIcons.TabIndex = 3;
            // 
            // lb_CL_T
            // 
            this.lb_CL_T.AutoSize = true;
            this.lb_CL_T.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CL_T.Location = new System.Drawing.Point(73, 50);
            this.lb_CL_T.Name = "lb_CL_T";
            this.lb_CL_T.Size = new System.Drawing.Size(24, 30);
            this.lb_CL_T.TabIndex = 13;
            this.lb_CL_T.Text = "T";
            this.lb_CL_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CL_S
            // 
            this.lb_CL_S.AutoSize = true;
            this.lb_CL_S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CL_S.Location = new System.Drawing.Point(43, 50);
            this.lb_CL_S.Name = "lb_CL_S";
            this.lb_CL_S.Size = new System.Drawing.Size(24, 30);
            this.lb_CL_S.TabIndex = 12;
            this.lb_CL_S.Text = "S";
            this.lb_CL_S.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CL_F
            // 
            this.lb_CL_F.AutoSize = true;
            this.lb_CL_F.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CL_F.Location = new System.Drawing.Point(133, 50);
            this.lb_CL_F.Name = "lb_CL_F";
            this.lb_CL_F.Size = new System.Drawing.Size(24, 30);
            this.lb_CL_F.TabIndex = 11;
            this.lb_CL_F.Text = "F";
            this.lb_CL_F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CL_B
            // 
            this.lb_CL_B.AutoSize = true;
            this.lb_CL_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CL_B.Location = new System.Drawing.Point(103, 50);
            this.lb_CL_B.Name = "lb_CL_B";
            this.lb_CL_B.Size = new System.Drawing.Size(24, 30);
            this.lb_CL_B.TabIndex = 10;
            this.lb_CL_B.Text = "B";
            this.lb_CL_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_ColorF
            // 
            this.pn_ColorF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ColorF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ColorF.Location = new System.Drawing.Point(130, 0);
            this.pn_ColorF.Margin = new System.Windows.Forms.Padding(0);
            this.pn_ColorF.Name = "pn_ColorF";
            this.pn_ColorF.Size = new System.Drawing.Size(30, 50);
            this.pn_ColorF.TabIndex = 8;
            // 
            // pn_ColorB
            // 
            this.pn_ColorB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ColorB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ColorB.Location = new System.Drawing.Point(100, 0);
            this.pn_ColorB.Margin = new System.Windows.Forms.Padding(0);
            this.pn_ColorB.Name = "pn_ColorB";
            this.pn_ColorB.Size = new System.Drawing.Size(30, 50);
            this.pn_ColorB.TabIndex = 7;
            // 
            // pn_ColorT
            // 
            this.pn_ColorT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ColorT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ColorT.Location = new System.Drawing.Point(70, 0);
            this.pn_ColorT.Margin = new System.Windows.Forms.Padding(0);
            this.pn_ColorT.Name = "pn_ColorT";
            this.pn_ColorT.Size = new System.Drawing.Size(30, 50);
            this.pn_ColorT.TabIndex = 6;
            // 
            // pn_ColorS
            // 
            this.pn_ColorS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ColorS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ColorS.Location = new System.Drawing.Point(40, 0);
            this.pn_ColorS.Margin = new System.Windows.Forms.Padding(0);
            this.pn_ColorS.Name = "pn_ColorS";
            this.pn_ColorS.Size = new System.Drawing.Size(30, 50);
            this.pn_ColorS.TabIndex = 5;
            // 
            // pn_ColorP
            // 
            this.pn_ColorP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ColorP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ColorP.Location = new System.Drawing.Point(10, 0);
            this.pn_ColorP.Margin = new System.Windows.Forms.Padding(0);
            this.pn_ColorP.Name = "pn_ColorP";
            this.pn_ColorP.Size = new System.Drawing.Size(30, 50);
            this.pn_ColorP.TabIndex = 4;
            // 
            // lb_CL_P
            // 
            this.lb_CL_P.AutoSize = true;
            this.lb_CL_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CL_P.Location = new System.Drawing.Point(13, 50);
            this.lb_CL_P.Name = "lb_CL_P";
            this.lb_CL_P.Size = new System.Drawing.Size(24, 30);
            this.lb_CL_P.TabIndex = 9;
            this.lb_CL_P.Text = "P";
            this.lb_CL_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Location = new System.Drawing.Point(88, 113);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(79, 24);
            this.btn_Apply.TabIndex = 1;
            this.btn_Apply.Tag = "Fore:F Back:S BtnBorder:T";
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            // 
            // cb_Presets
            // 
            this.tlp_PresetsBox.SetColumnSpan(this.cb_Presets, 2);
            this.cb_Presets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Presets.FormattingEnabled = true;
            this.cb_Presets.Location = new System.Drawing.Point(3, 83);
            this.cb_Presets.Name = "cb_Presets";
            this.cb_Presets.Size = new System.Drawing.Size(164, 23);
            this.cb_Presets.TabIndex = 2;
            // 
            // cb_Preview
            // 
            this.cb_Preview.AutoSize = true;
            this.cb_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Preview.Location = new System.Drawing.Point(3, 113);
            this.cb_Preview.Name = "cb_Preview";
            this.cb_Preview.Size = new System.Drawing.Size(79, 24);
            this.cb_Preview.TabIndex = 4;
            this.cb_Preview.Text = "Preview";
            this.cb_Preview.UseVisualStyleBackColor = true;
            this.cb_Preview.CheckedChanged += new System.EventHandler(this.cb_Preview_CheckedChanged);
            // 
            // gb_Colors
            // 
            this.gb_Colors.Controls.Add(this.tlp_ColorSliders);
            this.gb_Colors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Colors.Location = new System.Drawing.Point(170, 89);
            this.gb_Colors.Margin = new System.Windows.Forms.Padding(0);
            this.gb_Colors.Name = "gb_Colors";
            this.gb_Colors.Padding = new System.Windows.Forms.Padding(0);
            this.tlp_Appearance.SetRowSpan(this.gb_Colors, 3);
            this.gb_Colors.Size = new System.Drawing.Size(250, 736);
            this.gb_Colors.TabIndex = 5;
            this.gb_Colors.TabStop = false;
            this.gb_Colors.Tag = "Back:B";
            this.gb_Colors.Text = "Colors";
            // 
            // tlp_ColorSliders
            // 
            this.tlp_ColorSliders.AutoScroll = true;
            this.tlp_ColorSliders.ColumnCount = 1;
            this.tlp_ColorSliders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ColorSliders.Controls.Add(this.cs_F, 0, 4);
            this.tlp_ColorSliders.Controls.Add(this.cs_B, 0, 3);
            this.tlp_ColorSliders.Controls.Add(this.cs_T, 0, 2);
            this.tlp_ColorSliders.Controls.Add(this.cs_S, 0, 1);
            this.tlp_ColorSliders.Controls.Add(this.cs_P, 0, 0);
            this.tlp_ColorSliders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ColorSliders.Location = new System.Drawing.Point(0, 16);
            this.tlp_ColorSliders.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_ColorSliders.Name = "tlp_ColorSliders";
            this.tlp_ColorSliders.RowCount = 6;
            this.tlp_ColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_ColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_ColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_ColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_ColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_ColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ColorSliders.Size = new System.Drawing.Size(250, 720);
            this.tlp_ColorSliders.TabIndex = 0;
            // 
            // cs_F
            // 
            this.cs_F.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cs_F.Location = new System.Drawing.Point(3, 581);
            this.cs_F.Name = "cs_F";
            this.cs_F.Size = new System.Drawing.Size(244, 146);
            this.cs_F.TabIndex = 4;
            // 
            // cs_B
            // 
            this.cs_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cs_B.Location = new System.Drawing.Point(3, 435);
            this.cs_B.Name = "cs_B";
            this.cs_B.Size = new System.Drawing.Size(244, 140);
            this.cs_B.TabIndex = 3;
            // 
            // cs_T
            // 
            this.cs_T.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cs_T.Location = new System.Drawing.Point(3, 289);
            this.cs_T.Name = "cs_T";
            this.cs_T.Size = new System.Drawing.Size(244, 140);
            this.cs_T.TabIndex = 2;
            // 
            // cs_S
            // 
            this.cs_S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cs_S.Location = new System.Drawing.Point(3, 143);
            this.cs_S.Name = "cs_S";
            this.cs_S.Size = new System.Drawing.Size(244, 140);
            this.cs_S.TabIndex = 1;
            // 
            // cs_P
            // 
            this.cs_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cs_P.Location = new System.Drawing.Point(0, 0);
            this.cs_P.Margin = new System.Windows.Forms.Padding(0);
            this.cs_P.Name = "cs_P";
            this.cs_P.Size = new System.Drawing.Size(250, 140);
            this.cs_P.TabIndex = 0;
            // 
            // form_StandardView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(886, 833);
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
            this.tlp_PresetsBox.ResumeLayout(false);
            this.tlp_PresetsBox.PerformLayout();
            this.tlp_PresetIcons.ResumeLayout(false);
            this.tlp_PresetIcons.PerformLayout();
            this.gb_Colors.ResumeLayout(false);
            this.tlp_ColorSliders.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tlp_PresetsBox;
        private System.Windows.Forms.TableLayoutPanel tlp_PresetIcons;
        private System.Windows.Forms.Panel pn_ColorB;
        private System.Windows.Forms.Panel pn_ColorT;
        private System.Windows.Forms.Panel pn_ColorS;
        private System.Windows.Forms.Panel pn_ColorP;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.ComboBox cb_Presets;
        private System.Windows.Forms.GroupBox gb_Colors;
        private System.Windows.Forms.RadioButton rb_Presets;
        private System.Windows.Forms.Panel pn_ColorF;
        private System.Windows.Forms.Label lb_CL_T;
        private System.Windows.Forms.Label lb_CL_S;
        private System.Windows.Forms.Label lb_CL_F;
        private System.Windows.Forms.Label lb_CL_B;
        private System.Windows.Forms.Label lb_CL_P;
        private System.Windows.Forms.TableLayoutPanel tlp_ColorSliders;
        private ColorSlider cs_P;
        private ColorSlider cs_F;
        private ColorSlider cs_B;
        private ColorSlider cs_T;
        private ColorSlider cs_S;
        private System.Windows.Forms.CheckBox cb_Preview;
    }
}

