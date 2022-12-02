using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Explorer_Tools
{
    public static class ColorRegistry
    {
        public static List<RCEntry> RegisteredColors;
        public static List<RCEntry> DeadEntries = new List<RCEntry>();

        public struct RCEntry
        {
            public ColorReg CR;
            public IRegisteredColor Owner;
        }

        public static void RegisterColor(ColorReg reg, IRegisteredColor toRegister)
        {
            if (RegisteredColors is null) RegisteredColors = new List<RCEntry>();

            RegisteredColors.Add(new RCEntry() { CR = reg, Owner = toRegister });
        }

        public static void RefreshCategory(ColorRegType Type)
        {
            List<ColorReg> Targets = (from ColorReg c in RegisteredColors where c.RegType.Equals(Type) select c).ToList();
            foreach (ColorReg r in Targets)
            {
                
            }
        }

        public static void Prune()
        {
            RegisteredColors.RemoveAll(x => DeadEntries.Contains(x));
            DeadEntries.Clear();
        }
    }
}
