using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Explorer_Tools
{
    public static class ColorRegistry
    {
        public static HashSet<RCEntry> RegisteredColors;
        public class RCEntry
        {
            public ColorReg CR;
            public IRegisteredColor Owner;
        }

        public class RCEntry_Folder : RCEntry
        {
            public string FolderPath;
        }
        public class RCEntry_File : RCEntry
        {
            public string FilePath;
        }

        public static void RegisterColor(ColorReg reg, IRegisteredColor toRegister, md_File md)
        {
            if (RegisteredColors is null) RegisteredColors = new HashSet<RCEntry>();

            RegisteredColors.Add(new RCEntry_File() { CR = reg, Owner = toRegister, FilePath = md.FilePath });
        }

        public static void RegisterColor(ColorReg reg, IRegisteredColor toRegister, md_Folder md)
        {
            if (RegisteredColors is null) RegisteredColors = new HashSet<RCEntry>();

            RegisteredColors.Add(new RCEntry_Folder() { CR = reg, Owner = toRegister, FolderPath = md.FolderPath });
        }

        public static void RefreshCategory(ColorRegType Type)
        {
            List<RCEntry> Targets = (from RCEntry c in RegisteredColors where c.CR.RegType.Equals(Type) select c).ToList();
            foreach (RCEntry r in Targets)
            {
                r.Owner.UpdateVisuals();
            }
        }
    }
}
