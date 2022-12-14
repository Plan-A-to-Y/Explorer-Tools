using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Explorer_Tools.StyleOptions;

namespace Explorer_Tools
{
    public interface StyleWindow
    {
        public void UpdateVisuals();
        public List<ColorSlot> FormColors { get; set; }
    }
    public static class StyleOptions
    {
        [Serializable]
        public struct ColorSlot
        {
            public string DisplayName { get; set; }
            public colorSlot Slot { get; set; }
            public Color Color { get
                {
                    colorSlot _slot = Slot;
                    if (_color.Equals("§")) return ColorFromString(Metadata.DefaultColors.Find(x => x.Slot.Equals(_slot)).ColorString);
                    else return ColorFromString(_color);
                } 
                set
                {
                    return;
                }
            }

            public string ColorString 
            { 
                get {
                    return _color;
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
                _color = "§";
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
        public const int HCO = 50;
        public static Color Highlight(Color basecolor)
        {
            if (basecolor.GetBrightness() < 0.7)
            {
                return Color.FromArgb(255, basecolor.R + HCO, basecolor.G + HCO, basecolor.B + HCO);
            }
            else
            {
                return Color.FromArgb(255, basecolor.R - HCO, basecolor.G - HCO, basecolor.B - HCO);
            }
        }
        public static Image GetIcon(string icon)
        {
            //Path Format
            //Type 1: "Path:XX/XX/XXXXX/XXXX.png" -- Used for single-override icons
            //Type 2: "Preset:[x]|[#]" -- [x] = File Extension or identifier (ex. ".png" ".jpg") [#] = Slot ID (Kept in Metadata.IconSlots)
            //Type 3: "D:[IcoType]" -- Uses the default icon for the given IcoType
            try
            {
                if (icon is null) return Image.FromFile(Metadata.Icons[0]);

                if (icon.Contains("Path:")) return Image.FromFile(icon.Replace("Path:", ""));
                else if (Enum.TryParse(typeof(Metadata.Types), icon, out var tp))
                {
                    switch(tp)
                    {
                        case Metadata.Types.File:
                            return Image.FromFile(Metadata.DefaultIcon_File);
                        case Metadata.Types.Folder:
                            return Image.FromFile(Metadata.DefaultIcon_Folder);
                        case Metadata.Types.Text:
                            return Image.FromFile(Metadata.DefaultIcon_Text);
                        case Metadata.Types.Image:
                            return Image.FromFile(Metadata.DefaultIcon_Image);
                        default:
                            break;
                    }
                }

                if (icon.Contains("Preset:"))
                {
                    return Image.FromFile((from Ex in Metadata.ExtIcons where Ex.ext.Equals(icon.Replace("Preset:", "").Split("|")[0]) select Ex).ToArray()[int.Parse(icon.Split("|")[1])].path);
                }
                else if (icon.Split(":").Contains("§"))
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
            Highlight,
            Background,
            Primary,
            Secondary,
            Tertiary,
            TextColor,
            SecondaryTextColor
        }


        public static Color GetColor(string Path, colorSlot @override)
        {
            string colorvalue = "§";
            if (Directory.Exists(Path)) colorvalue = Metadata.FindFolderData(Path).FormColors.Find(x => x.Slot == @override).ColorString;
            else if (File.Exists(Path)) colorvalue = Metadata.FindFileData(Path).FormColors.Find(x => x.Slot == @override).ColorString;

            if (colorvalue.Equals("§")) return Metadata.DefaultColors.Find(x => x.Slot == @override).Color;
            //if ()
            else return ColorFromString(colorvalue);
        }

        public static Color GetColor(md_Folder md, colorSlot @override)
        {
            string colorvalue = "§";
            colorvalue = md.FormColors.Find(x => x.Slot == @override).ColorString;
            if (colorvalue.Equals("§")) return Metadata.DefaultColors.Find(x => x.Slot == @override).Color;
            else return ColorFromString(colorvalue);
        }
        public static Color GetColor(md_File md, colorSlot @override)
        {
            string colorvalue = "§";
            colorvalue = md.FormColors.Find(x => x.Slot == @override).ColorString;
            if (colorvalue.Equals("§")) return Metadata.DefaultColors.Find(x => x.Slot == @override).Color;
            else return ColorFromString(colorvalue);
        }
        public static Color GetColor(colorSlot @override)
        {
            return Metadata.DefaultColors.Find(x => x.Slot == @override).Color;
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

        public static void ApplyColorTags(Control Target)
        {
            List<Control> AllCon = new List<Control>();
            Queue<Control> ToSearch = new Queue<Control>();
            foreach (Control c in Target.Controls)
            {
                AllCon.Add(c);
                ToSearch.Enqueue(c);
            }
            while (ToSearch.Count > 0)
            {
                Control Searching = ToSearch.Dequeue();
                foreach (Control d in Searching.Controls)
                {
                    if (!AllCon.Contains(d)) AllCon.Add(d);
                    ToSearch.Enqueue(d);
                }
            }

            foreach (Control c in AllCon)
            {
                List<string> slots = new List<string> { "Fore", "Back", "BtnBorder", "TabHeader" };
                foreach (string slot in slots)
                {
                    if (c.Tag is null) continue;
                    bool Valid = false;
                    Color col = Color.White;
                    if (c.Tag.ToString().Contains(slot))
                    {
                        switch (c.Tag.ToString())
                        {
                            case string a when a.Contains(slot + ":ST"):
                                col = StyleOptions.GetColor(StyleOptions.colorSlot.SecondaryTextColor);
                                Valid = true;
                                break;
                            case string a when a.Contains(slot + ":P"):
                                col = StyleOptions.GetColor(StyleOptions.colorSlot.Primary);
                                Valid = true;
                                break;
                            case string a when a.Contains(slot + ":S"):
                                col = StyleOptions.GetColor(StyleOptions.colorSlot.Secondary);
                                Valid = true;
                                break;
                            case string a when a.Contains(slot + ":T"):
                                col = StyleOptions.GetColor(StyleOptions.colorSlot.Tertiary);
                                Valid = true;
                                break;
                            case string a when a.Contains(slot + ":B"):
                                col = StyleOptions.GetColor(StyleOptions.colorSlot.Background);
                                Valid = true;
                                break;
                            case string a when a.Contains(slot + ":F"):
                                col = StyleOptions.GetColor(StyleOptions.colorSlot.TextColor);
                                Valid = true;
                                break;

                        }
                    }
                    if (Valid && slot.Equals("Fore")) c.ForeColor = col;
                    if (Valid && slot.Equals("Back")) c.BackColor = col;
                    if (Valid && slot.Equals("BtnBorder")) ((Button)c).FlatAppearance.BorderColor = col;
                }

            }
        }
    }
}
