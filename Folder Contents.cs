using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static Explorer_Tools.Metadata;
using static Explorer_Tools.StyleOptions;
namespace Explorer_Tools
{
    public partial class Folder_Contents : Form, IDisplayForm, StyleWindow, IRegisteredColor
    {
        string IDisplayForm.DisplayName { get; set; }
        md_Folder md;
        public IFileIcon SelectedFile;
        public List<string> ImageTypes = new List<string> { "IGNORE" }; //{ ".bmp", ".png", ".jpg", ".jpeg", ".gif" };
        public List<string> TextTypes = new List<string> { "IGNORE" }; //{ ".txt" };
        public List<string> DocTypes = new List<string> { "IGNORE" }; //{ ".docx" };
        public SortTypes Sort = SortTypes.Name;
        public bool IsSelected { get; set; }
        public string FolderPath { get; set; }
        public int FolderId { get; set; }
        List<ColorSlot> StyleWindow.FormColors { get { return Metadata.FindFolderData(FolderPath).FormColors; } set { Metadata.FindFolderData(FolderPath).FormColors = value; } }
        List<IIcon> IDisplayForm.SelectedItems { get; set; }
        public bool isSelected { get; set; }
        public IView OwningView { get; set; }

        public static List<FilterTypes> FilterCriteria = new List<FilterTypes> { FilterTypes.Type, FilterTypes.Extension, FilterTypes.Tag };
        bool Moving = false;
        Point offset;



        public Folder_Contents()
        {
            InitializeComponent();
            FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            md = FindFolderData(FolderPath);
            this.TopLevel = false;
            ((IDisplayForm)this).SelectedItems = new List<IIcon>();
            SortButton SB_Name = new SortButton(SortTypes.Name, this);
            SB_Name.Text = "Name";
            SB_Name.Click += SortBy;
            tsb_Edit.DropDownItems.Add(SB_Name);

            SortButton SB_Size = new SortButton(SortTypes.Size, this);
            SB_Size.Text = "Size";
            SB_Size.Click += SortBy;
            tsb_Edit.DropDownItems.Add(SB_Size);

            SortButton SB_Date = new SortButton(SortTypes.DateModified, this);
            SB_Date.Text = "Date Modified";
            SB_Date.Click += SortBy;
            tsb_Edit.DropDownItems.Add(SB_Date);
            ColorRegistry.RegisterColor(new ColorReg(), this);
            tlp_Filters.Hide();
            panel_Content.Refresh();
            cb_FilterType.DataSource = FilterCriteria;
            cb_FilterType.SelectedIndex = 0;
            
        }

        public void AddEntry(string file)
        {
            Control iEntry;
            string ext = "." + file.Split('.').Last();
            iEntry = new File_Entry(file, this);
            ((IIcon)iEntry).Owner = this;
            panel_Content.Controls.Add(iEntry);
            iEntry.MouseMove += ClickAndDrag;
            iEntry.Show();
        }

        public void RemoveFile(IFileIcon file)
        {
            panel_Content.Controls.Remove((from Control c in panel_Content.Controls where ((File_Entry)c).FilePath.Equals(file.FilePath) select c).First());
        }

        private void ClickAndDrag(object sender, MouseEventArgs e)
        {

        }

        public class SortButton : ToolStripButton
        {
            public SortTypes ST = SortTypes.Name;
            public Folder_Contents fc;
            public SortButton(SortTypes sortType, Folder_Contents FC)
            {
                ST = sortType;
                fc = FC;
            }
        }

        public void SortBy(object sender, EventArgs e)
        {
            ((SortButton)sender).fc.DisplayContents(((SortButton)sender).fc.FolderPath, ((SortButton)sender).ST);
        }

        public int Compare([AllowNull] md_File x, [AllowNull] md_File y, SortTypes t = SortTypes.Name)
        {
            switch (t)
            {
                case SortTypes.Name:
                    return string.CompareOrdinal(x.DisplayName, y.DisplayName);
                case SortTypes.Size:
                    FileInfo xi = new FileInfo(x.FilePath);
                    FileInfo yi = new FileInfo(y.FilePath);
                    return (xi.Length > yi.Length ? -1 : 1);
                case SortTypes.DateModified:
                    FileInfo xdi = new FileInfo(x.FilePath);
                    FileInfo ydi = new FileInfo(y.FilePath);
                    return xdi.LastWriteTime.CompareTo(ydi.LastWriteTime);
                case SortTypes.Tag:
                    return 0;
                default:
                    return 0;
            }
        }
        public void DisplayContents(string Path, Metadata.SortTypes order = SortTypes.Name)
        {
            ((IDisplayForm)this).DisplayName = Path.Split("\\").Last();
            OwningView.ActiveDisplayForm = this;
            if (Path.Equals(FolderPath))
            {
                if (Sort != order)
                {
                    Sort = order;
                    List<File_Entry> sortedar = new List<File_Entry>();
                    switch (order)
                    {
                        case SortTypes.Name:
                            sortedar = (from File_Entry x in panel_Content.Controls orderby ((File_Entry)x).Name select x).ToList();
                            break;
                        case SortTypes.Size:
                            sortedar = (from File_Entry x in panel_Content.Controls orderby new FileInfo(x.FilePath).Length descending select x).ToList();
                            break;
                        case SortTypes.DateModified:
                            sortedar = (from File_Entry x in panel_Content.Controls orderby new FileInfo(x.FilePath).LastWriteTime descending select x).ToList();
                            break;
                        case SortTypes.Tag:
                            sortedar = (from File_Entry x in panel_Content.Controls orderby ((File_Entry)x).Name select x).ToList();
                            break;
                    }
                    foreach (File_Entry fe in sortedar)
                    {
                        panel_Content.Controls.SetChildIndex(fe, sortedar.IndexOf(fe));
                    }
                }
                if (Blacklist.Count > 0 || Whitelist.Count > 0)
                {
                    foreach (File_Entry file in panel_Content.Controls)
                    {
                        md_File filemd = Metadata.FindFileData(file.FilePath);
                        bool WhitelistMatch = false;
                        if (Whitelist.Count > 0)
                        {
                            foreach (Predicate<md_File> p in Whitelist)
                            {
                                if (p(filemd))
                                {
                                    WhitelistMatch = true;
                                }
                            }
                            if (WhitelistMatch) file.Show();
                            else file.Hide();
                        }
                        if (Blacklist.Count > 0 && WhitelistMatch)
                        {
                            bool BlacklistMatch = false;
                            foreach (Predicate<md_File> p in Blacklist)
                            {
                                if (p(filemd))
                                {
                                    BlacklistMatch = true;
                                }
                            }
                            if (BlacklistMatch == true) file.Hide();
                        }
                    }
                }
            }
            else
            {
                md = Metadata.FindFolderData(Path);
                FolderId = md.FolderId;
                FolderPath = Path;
                lb_FolderName.Text = md.DisplayName;
                pb_FolderIcon.Image = Image.FromFile(md.IconPath);
                FolderId = md.FolderId;
                FolderPath = Path;
                panel_Content.Controls.Clear();
                string[] files = Directory.GetFiles(FolderPath);
                if (order == SortTypes.Name) { files = (from f in files orderby f.First() select f).ToArray<string>(); }
                else if (order == SortTypes.Size) { files = (from f in files orderby new FileInfo(f).Length descending select f).ToArray<string>(); }
                else if (order == SortTypes.DateModified) { files = (from f in files orderby new FileInfo(f).LastWriteTime select f).ToArray<string>(); }
                foreach (string file in files)
                {
                    if (Whitelist.Count > 0)
                    {
                        bool WhitelistMatch = false;
                        foreach (Predicate<md_File> p in Whitelist)
                        {
                            if (p(Metadata.FindFileData(file)))
                            {
                                WhitelistMatch = true;
                            }
                        }
                        if (WhitelistMatch == false) continue;
                    }
                    if (Blacklist.Count > 0)
                    {
                        bool BlacklistMatch = false;
                        foreach (Predicate<md_File> p in Blacklist)
                        {
                            if (p(Metadata.FindFileData(file)))
                            {
                                BlacklistMatch = true;
                            }
                        }
                        if (BlacklistMatch == true) continue;
                    }
                    Control iEntry;
                    string ext = "." + file.Split('.').Last();
                    iEntry = new File_Entry(file, this);
                    ((IIcon)iEntry).Owner = this;
                    panel_Content.Controls.Add(iEntry);
                    iEntry.Show();
                }
            }
            panel_Content.Refresh();
            UpdateVisuals();
        }

        public void UpdateVisuals()
        {
            tlp_Header.BackColor = GetColor(md, colorSlot.Primary);
            ts_FolderTools.BackColor = GetColor(md, colorSlot.Primary);
            btn_ShowFilters.BackColor = GetColor(md, colorSlot.Primary);
            tlp_Filters.BackColor = GetColor(md, colorSlot.Primary);
            btn_ShowTools.BackColor = GetColor(md, colorSlot.Primary);

            pn_BottomBorder.BackColor = GetColor(md, colorSlot.Secondary);
            pn_TopBorder.BackColor = GetColor(md, colorSlot.Secondary);
            pn_LeftBorder.BackColor = GetColor(md, colorSlot.Secondary);
            pn_RightBorder.BackColor = GetColor(md, colorSlot.Secondary);

            pn_TopLeft.BackColor = GetColor(md, colorSlot.Tertiary);
            pn_TopRight.BackColor = GetColor(md, colorSlot.Tertiary);
            pn_BottomLeft.BackColor = GetColor(md, colorSlot.Tertiary);
            pn_BottomRight.BackColor = GetColor(md, colorSlot.Tertiary);

            panel_Content.BackColor = GetColor(md, colorSlot.Background);

            lb_FolderName.ForeColor = GetColor(md, colorSlot.TextColor);
            tsb_File.ForeColor = GetColor(md, colorSlot.TextColor);
            tsb_Edit.ForeColor = GetColor(md, colorSlot.TextColor);
            btn_ShowFilters.ForeColor = GetColor(md, colorSlot.TextColor);
            btn_ShowTools.ForeColor = GetColor(md, colorSlot.TextColor);
            ts_FolderTools.Renderer = new MyRenderer();
            ((MyRenderer)ts_FolderTools.Renderer).SetArrowColor(GetColor(md, colorSlot.TextColor));

            tlp_Content.BackColor = GetColor(md, colorSlot.Tertiary);
        }

        public class MyRenderer : ToolStripRenderer
        {
            public Color ArrowColor = Color.White;
            public void SetArrowColor(Color newarrowcolor)
            {
                ArrowColor = newarrowcolor;
            }
            protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
            {
                e.ArrowColor = ArrowColor;
                base.OnRenderArrow(e);
            }

        }

        private void folderContents_SizeChanged(object sender, EventArgs e)
        {

        }

        private void btn_ToggleFull_Click(object sender, EventArgs e)
        {
            Dock = DockStyle.None;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel_Header_MouseDown(object sender, MouseEventArgs e)
        {
            Moving = true;
            offset = new Point(e.X, e.Y);
            tlp_Header.BackColor = Highlight(GetColor(md, colorSlot.Primary));

            
        }

        private void Folder_Contents_MouseMove(object sender, MouseEventArgs e)
        {
            if (Moving)
            {
                Point newloc = Location;
                newloc.X += e.X - offset.X;
                newloc.Y += e.Y - offset.Y;
                Location = newloc;
            }
        }

        private void panel_Header_MouseUp(object sender, MouseEventArgs e)
        {
            if (Moving)
            {
                Moving = false;
                tlp_Header.BackColor = GetColor(md, colorSlot.Primary);
            }
        }

        bool ResizeLeft = false;
        bool ResizeRight = false;
        bool ResizeTop = false;
        bool ResizeBottom = false;
        bool ResizeActive = false;
        int[] Cell = new int[2];
        int XCoord;
        int YCoord;



        private void resize_MouseDown(object sender, MouseEventArgs e)
        {
            offset = new Point(e.X, e.Y);
            ResizeActive = true;
        }

        private void resize_MouseMove(object sender, MouseEventArgs e)
        {

            if ((sender as Panel).Name.Contains("Top")) ResizeTop = true; Cursor.Current = Cursors.SizeNS;
            if ((sender as Panel).Name.Contains("Bottom")) ResizeBottom = true; Cursor.Current = Cursors.SizeNS;
            if ((sender as Panel).Name.Contains("Left")) ResizeLeft = true; Cursor.Current = Cursors.SizeWE;
            if ((sender as Panel).Name.Contains("Right")) ResizeRight = true; Cursor.Current = Cursors.SizeWE;

            if ((ResizeRight && ResizeTop) || (ResizeLeft && ResizeBottom)) Cursor.Current = Cursors.SizeNESW;
            if ((ResizeLeft && ResizeTop) || (ResizeRight && ResizeBottom)) Cursor.Current = Cursors.SizeNWSE;

            if (ResizeActive)
            {
                Point Movement = new Point(e.X - offset.X, e.Y - offset.Y);
                if (ResizeLeft)
                {
                    if (Movement.X > 0 && Width != MinimumSize.Width)
                    {
                        Location = new Point(Location.X + Movement.X, Location.Y);
                        Width -= Math.Abs(Movement.X);
                    }
                    else if (Movement.X < 0)
                    {
                        Location = new Point(Location.X + Movement.X, Location.Y);
                        Width += Math.Abs(Movement.X);
                    }
                }

                if (ResizeRight)
                {
                    Width += Movement.X;
                }

                if (ResizeBottom)
                {
                    Height += Movement.Y;
                }
                if (ResizeTop)
                {
                    if (Height != MinimumSize.Height) Location = new Point(Location.X, Location.Y + Movement.Y);
                    Height -= Movement.Y;
                }
            }

        }

        private void Resize_MouseUp(object sender, MouseEventArgs e)
        {
            ResizeLeft = false;
            ResizeRight = false;
            ResizeBottom = false;
            ResizeTop = false;
            ResizeActive = false;
            Cursor.Current = Cursors.Default;
        }

        private void Resize_MouseLeave(object sender, EventArgs e)
        {
            ResizeLeft = false;
            ResizeRight = false;
            ResizeBottom = false;
            ResizeTop = false;
            Cursor.Current = Cursors.Default;
        }

        private void pn_TopLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_Left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_TopBorder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_TopRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_Right_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Selected()
        {
            OwningView.ActiveDisplayForm = this;
        }

        public void Deselected()
        {
            throw new NotImplementedException();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EditWindow EW = new EditWindow();
            EW.EditFolder = true;
            EW.Setup(md, this);
            EW.ShowDialog();
        }

        private void pn_BottomBorder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ShowFilters_Click(object sender, EventArgs e)
        {
            btn_ShowFilters.Hide();
            tlp_Filters.Show();
        }

        private void btn_ShowTools_Click(object sender, EventArgs e)
        {
            btn_ShowFilters.Show();
            tlp_Filters.Hide();
        }



        private void cb_FilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            flp_Filters.Controls.Clear();
            if (cb_FilterType.SelectedItem.Equals(FilterTypes.Type))
            {
                List<Types> PresentTypes = new List<Types>();
                foreach (string f in Directory.GetFiles(FolderPath))
                {
                    if (!PresentTypes.Contains(Metadata.GetFileType(f))) { PresentTypes.Add(GetFileType(f)); }
                }
                foreach (Types t in PresentTypes)
                {
                    FilterButton fb = new FilterButton(this);
                    fb.t = t;
                    fb.FilterCriteria = (x => Metadata.GetFileType(x.FilePath).Equals(t));
                    fb.Text = t.ToString();
                    flp_Filters.Controls.Add(fb);
                }

            }
            else if (cb_FilterType.SelectedItem.Equals(FilterTypes.Extension))
            {
                List<string> PresentExtensions = new List<string>();
                foreach (string f in Directory.GetFiles(FolderPath))
                {
                    if(!PresentExtensions.Contains(f.Split(".").Last()))
                    {
                        PresentExtensions.Add(f.Split(".").Last());
                    }
                }
                foreach (string t in PresentExtensions)
                {
                    FilterButton fb = new FilterButton(this);
                    fb.FilterCriteria = (x => x.FilePath.Split(".").Last().Equals(t));
                    fb.Text = t.ToString();
                    fb.AutoSize = true;
                    flp_Filters.Controls.Add(fb);
                }
            }
            FilterButton fx = new FilterButton(this);
            fx.Text = "Show All";
            fx.FilterCriteria = (x => true);
            flp_Filters.Controls.Add(fx);
        }
        public HashSet<Predicate<md_File>> Whitelist = new HashSet<Predicate<md_File>>();
        public HashSet<Predicate<md_File>> Blacklist = new HashSet<Predicate<md_File>>();
        public enum EnabledState
        {
            Disabled,
            Whitelist,
            Blacklist
        }
        public class FilterButton : Button
        {
            public Predicate<md_File> FilterCriteria { get; set; }
            public Folder_Contents fc { get; set; }
            public Types t { get; set; }
            public EnabledState Status { get; set; }
            public FilterButton(Folder_Contents _fc)
            {
                fc = _fc;
                MouseUp += _fc.FilterBtnClick;
                BackColor = GetColor(fc.md, colorSlot.Background);
                ForeColor = GetColor(fc.md, colorSlot.TextColor);
                FlatAppearance.BorderColor = GetColor(fc.md, colorSlot.Secondary);
                FlatStyle = FlatStyle.Flat;
            }
        }

        private void FilterBtnClick(object sender, EventArgs e)
        {
            Folder_Contents fc = (sender as FilterButton).fc;
            FilterButton invoker = sender as FilterButton;
            if(((MouseEventArgs)e).Button == MouseButtons.Left)
            {
                switch (invoker.Status)
                {
                    case EnabledState.Disabled:
                        {
                            Whitelist.Add(invoker.FilterCriteria);
                            invoker.Status = EnabledState.Whitelist;
                            invoker.BackColor = Color.White;
                            invoker.ForeColor = Color.Black;
                            break;
                        }
                    case EnabledState.Whitelist:
                        {
                            Whitelist.Remove(invoker.FilterCriteria);
                            invoker.Status = EnabledState.Disabled;
                            invoker.BackColor = GetColor(fc.md, colorSlot.Background);
                            invoker.ForeColor = GetColor(fc.md, colorSlot.TextColor);
                            break;
                        }
                    case EnabledState.Blacklist:
                        {
                            Blacklist.Remove(invoker.FilterCriteria);
                            invoker.Status = EnabledState.Disabled;
                            invoker.BackColor = GetColor(fc.md, colorSlot.Background);
                            invoker.ForeColor = GetColor(fc.md, colorSlot.TextColor);
                            break;
                        }
                }
            }
            else if (((MouseEventArgs)e).Button == MouseButtons.Right)
            {
                switch (invoker.Status)
                {
                    case EnabledState.Disabled:
                        {
                            Blacklist.Add(invoker.FilterCriteria);
                            invoker.Status = EnabledState.Blacklist;
                            invoker.BackColor = Color.Black;
                            invoker.ForeColor = Color.White;
                            break;
                        }
                    case EnabledState.Whitelist:
                        {
                            Whitelist.Remove(invoker.FilterCriteria);
                            invoker.Status = EnabledState.Disabled;
                            invoker.BackColor = GetColor(fc.md, colorSlot.Background);
                            invoker.ForeColor = GetColor(fc.md, colorSlot.TextColor);
                            break;
                        }
                    case EnabledState.Blacklist:
                        {
                            Blacklist.Remove(invoker.FilterCriteria);
                            invoker.Status = EnabledState.Disabled;
                            invoker.BackColor = GetColor(fc.md, colorSlot.Background);
                            invoker.ForeColor = GetColor(fc.md, colorSlot.TextColor);
                            break;
                        }
                }
            }


            ((FilterButton)sender).fc.DisplayContents(((FilterButton)sender).fc.FolderPath);
        }

        private void panel_Content_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void panel_Content_DragDrop(object sender, DragEventArgs e)
        {
            var rawsource = e.Data.GetData(typeof(File_Entry));
            File_Entry sourceFE = (File_Entry)rawsource;
            string source = sourceFE.FilePath;
            File.Move(source, FolderPath+ "\\" + source.Split("\\").Last(),true);
            md_File md = FindFileData(source);
            md.FilePath = FolderPath + "\\" + source.Split("\\").Last();
            sourceFE.Owner.RemoveItem(sourceFE);
            UpdateFileData(md);
            sourceFE.Owner = this;
            AddEntry(md.FilePath);
        }

        private void pb_FolderIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Blacklist Count: {Blacklist.Count}\nWhitelist Count: {Whitelist.Count}");
            string result = "Whitelist:";
            foreach(Predicate<md_File> p in Whitelist)
            {
                result += "\n" + p.ToString();
            }
            MessageBox.Show(result);
            result = "Blacklist:";
            foreach (Predicate<md_File> p in Blacklist)
            {
                result += "\n" + p.ToString();
            }
            MessageBox.Show(result);
        }

        public void SelectItem(IIcon ToSelect)
        {
            File_Entry toSelect = ToSelect as File_Entry;
            OwningView.ActiveDisplayForm = this;
            //MessageBox.Show("Folder Contents has recieved selection event");
            toSelect.lb_FileName.BackColor = Highlight(toSelect.lb_FileName.BackColor);
            ((IDisplayForm)this).SelectedItems.Add(ToSelect);
        }

        public void DeselectItem(IIcon ToRemove)
        {
            File_Entry toDeselect = ToRemove as File_Entry;
            //MessageBox.Show("Folder Contents has recieved Deselection event");
            toDeselect.UpdateVisuals();
            ((IDisplayForm)this).SelectedItems.Remove(ToRemove);
        }

        public void RemoveItem(IIcon ToRemove)
        {
            panel_Content.Controls.Remove((from File_Entry x in panel_Content.Controls where x.FileId.Equals(((IFileIcon)ToRemove).FileId) select x).First());
        }

        public void AddItem(IIcon ToAdd)
        {
            if(ToAdd is IFileIcon)
            {
                IFileIcon ToAddFi = ToAdd as IFileIcon;
                if(File.Exists(FolderPath + $"\\{ToAddFi.FilePath.Split("\\").Last()}"))
                {
                    MessageBox.Show("File already exists in Directory: " + FolderPath + $"\\{ToAddFi.FilePath.Split("\\").Last()}");
                }
                else
                {
                    File.Copy(ToAddFi.FilePath, FolderPath + $"\\{ToAddFi.FilePath.Split("\\").Last()}");
                    MessageBox.Show("Copied to " + FolderPath + $"\\{ToAddFi.FilePath.Split("\\").Last()}");
                }
            }
        }

        public void IconDeselect()
        {
            throw new NotImplementedException();
        }

        private void Folder_Contents_Enter(object sender, EventArgs e)
        {
            Selected();
        }

        private void Folder_Contents_Leave(object sender, EventArgs e)
        {
            IsSelected = false;
        }

        private void tlp_Filters_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
