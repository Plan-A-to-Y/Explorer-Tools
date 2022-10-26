using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Explorer_Tools
{
    public static class StyleOptions
    {
        public enum colorSlot
        {
            SelectedColor,
            EntryColor
        }
        public struct ColorEntry
        {
            public ColorEntry(Color color, colorSlot slot)
            {
                OverrideColor = color;
                toOverride = slot;
            }
            public Color OverrideColor;
            public colorSlot toOverride { get; set; }
        }
        public struct IconEntry
        {
            public string IconPath;
            public colorSlot toOverride { get; set; }
        }

        public static List<ColorEntry> DefaultColors = new List<ColorEntry>{
            new ColorEntry(Color.AliceBlue, colorSlot.SelectedColor),
            new ColorEntry(Color.White, colorSlot.EntryColor)
            };

        public static Color GetColor(IFileIcon invoker, colorSlot @override)
        {
            var md = Metadata.FileMetadata.Find(x => x.FileId == invoker.FileId);
            if (md != null && !(md.ColorOverrides.Find(x => x.toOverride == @override).Equals(null)))
            { return (md.ColorOverrides.Find(x => x.toOverride == @override).OverrideColor); }
            else return DefaultColors.Find(x => x.toOverride == @override).OverrideColor;
        }
    }
}
