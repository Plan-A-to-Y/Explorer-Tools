using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Explorer_Tools
{
    public static class StyleOptions
    {
        [Serializable]
        public enum colorSlot
        {
            SelectedColor,
            EntryColor,
            BorderColor,
            BorderCornerColor
        }
        [Serializable]
        public struct ColorEntry
        {
            public ColorEntry(Color color, colorSlot slot)
            {
                if (color.IsEmpty) { OverrideColor = StringFromColor(Color.Red); }
                OverrideColor = StringFromColor(color);
                toOverride = slot;
            }
            public string OverrideColor { get; set; }
            public colorSlot toOverride { get; set; }
        }
        [Serializable]
        public struct IconEntry
        {
            public string[] IconPath { get; set; }
            public colorSlot toOverride { get; set; }
        }

        public static List<ColorEntry> DefaultColors = new List<ColorEntry>{
            new ColorEntry(Color.AliceBlue, colorSlot.SelectedColor),
            new ColorEntry(Color.White, colorSlot.EntryColor),
            new ColorEntry(Color.Orange, colorSlot.BorderColor),
            new ColorEntry(Color.DarkOrange, colorSlot.BorderCornerColor)
            };

        public static Color GetColor(IFileIcon invoker, colorSlot @override)
        {
            md_File md = Metadata.FindFileData(invoker.FilePath);
            if (md.ColorOverrides.Exists(x => ((uint)x.toOverride) == ((uint)@override))) return ColorFromString(md.ColorOverrides.Find(x => ((uint)x.toOverride) == ((uint)@override)).OverrideColor);
            else return ColorFromString(DefaultColors.Find(x => x.toOverride == @override).OverrideColor);
        }
        public static Color GetColor(IFolderIcon invoker, colorSlot @override)
        {
            md_Folder md = Metadata.FindFolderData(invoker.FolderPath);
            if (md.ColorOverrides.Exists(x => ((uint)x.toOverride) == ((uint)@override))) return ColorFromString(md.ColorOverrides.Find(x => ((uint)x.toOverride) == ((uint)@override)).OverrideColor);
            else return ColorFromString(DefaultColors.Find(x => x.toOverride == @override).OverrideColor);
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
