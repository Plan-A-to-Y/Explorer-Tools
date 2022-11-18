using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static Explorer_Tools.StyleOptions;
using System.IO;
using System.Windows.Forms;

namespace Explorer_Tools
{
    public interface StyleWindow
    {
        public void RefreshVisuals();
        public List<ColorSlot> FormColors { get; set; }
    }
    public static class StyleOptions
    {
        [Serializable]
        public struct ColorSlot
        {
            public string DisplayName { get; set; }
            public colorSlot Slot { get; set; }
            public string Color 
            { 
                get {
                    colorSlot _slot = Slot;
                    if (_color is null) { _color = "D"; }
                    if (_color.Equals("D")) return DefaultColors.Find(x => x.Slot.Equals(_slot)).Color;
                    else return _color;
                }
                set {
                    _color = value;
                } 
            }
            private string _color;

            public ColorSlot(colorSlot slot, string color)
            {
                Slot = slot;
                _color = color;
                DisplayName = slot.ToString();
            }
            public ColorSlot(colorSlot slot)
            {
                Slot = slot;
                _color = "D";
                DisplayName = slot.ToString();
            }
            public void UpdateColor(string NewColor)
            {
                this._color = NewColor;
            }

            public override bool Equals(object obj)
            {
                return this.Slot == ((ColorSlot)obj).Slot;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        public static Image GetIcon(string icon)
        {
            //Path Format
            //Type 1: "Path:XX/XX/XXXXX/XXXX.png" -- Used for single-override icons
            //Type 2: "Preset:[x]|[#]" -- [x] = File Extension or identifyer (ex. ".png" ".jpg") [#] = Slot ID (Kept in Metadata.IconSlots)
            //Type 3: "D:[IcoType]" -- Uses the default icon for the given IcoType
            try
            {
                if (icon.Contains("Path:")) return Image.FromFile(icon.Replace("Path:", ""));
                else if (icon.Contains("Preset:"))
                {
                    return Image.FromFile((from Ex in Metadata.ExtIcons where Ex.ext.Equals(icon.Replace("Preset:", "").Split("|")[0]) select Ex).ToArray()[int.Parse(icon.Split("|")[1])].path);
                }
                else if (icon.Split(":").Contains("D"))
                {
                    return Image.FromFile((from Ex in Metadata.ExtIcons where Ex.ext.Equals(icon.Split(":")[1]) select Ex).ToArray()[0].path);
                }
                else
                {
                    return Image.FromFile(Metadata.Icons[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Image.FromFile(Metadata.Icons[0]);
            }

        }


        [Serializable]
        public enum colorSlot
        {
            SelectedColor,
            EntryColor,
            HeaderColor,
            BorderColor,
            BorderCornerColor,
            TextColor
        }

        public static List<ColorSlot> DefaultColors = new List<ColorSlot>{
            new ColorSlot(colorSlot.SelectedColor, "100|50|100|255"),
            new ColorSlot(colorSlot.EntryColor, "80|80|80|255"),
            new ColorSlot(colorSlot.HeaderColor, "100|0|100|255"),
            new ColorSlot(colorSlot.BorderColor, "20|20|20|255"),
            new ColorSlot(colorSlot.BorderCornerColor, "255|255|255|255"),
            new ColorSlot(colorSlot.TextColor, "255|255|255|255")
            };


        public static Color GetColor(string Path, colorSlot @override)
        {
            string colorvalue = "D";
            if (Directory.Exists(Path)) colorvalue = Metadata.FindFolderData(Path).FormColors.Find(x => x.Slot == @override).Color;
            else if (File.Exists(Path)) colorvalue = Metadata.FindFileData(Path).FormColors.Find(x => x.Slot == @override).Color;

            if (colorvalue.Equals("D")) return ColorFromString(DefaultColors.Find(x => x.Slot == @override).Color);
            else return ColorFromString(colorvalue);
        }

        public static Color GetColor(md_Folder md, colorSlot @override)
        {
            string colorvalue = "D";
            colorvalue = md.FormColors.Find(x => x.Slot == @override).Color;
            if (colorvalue.Equals("D")) return ColorFromString(DefaultColors.Find(x => x.Slot == @override).Color);
            else return ColorFromString(colorvalue);
        }
        public static Color GetColor(md_File md, colorSlot @override)
        {
            string colorvalue = "D";
            colorvalue = md.FormColors.Find(x => x.Slot == @override).Color;
            if (colorvalue.Equals("D")) return ColorFromString(DefaultColors.Find(x => x.Slot == @override).Color);
            else return ColorFromString(colorvalue);
        }

        public static Color ColorFromString(string input)
        {
            if(input == null) { return Color.Red; }
            string[] SplitIn = input.Split('|');
            return Color.FromArgb(int.Parse(SplitIn[3]), int.Parse(SplitIn[0]), int.Parse(SplitIn[1]), int.Parse(SplitIn[2]));
        }

        public static string StringFromColor(Color input)
        {
            return $"{input.R}|{input.G}|{input.B}|{input.A}";
        }
    }
}
