using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Explorer_Tools
{
    public static class ColorRegistry
    {
        public static HashSet<RCEntry> RegisteredColors;
        public struct RCEntry
        {
            public ColorReg CR;
            public IRegisteredColor Owner;
        }

        public static void RegisterColor(ColorReg reg, IRegisteredColor toRegister)
        {
            if (RegisteredColors is null) RegisteredColors = new HashSet<RCEntry>();

            RegisteredColors.Add(new RCEntry() { CR = reg, Owner = toRegister });
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
