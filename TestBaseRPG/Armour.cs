using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestBaseRPG.Form1;

namespace TestBaseRPG
{
    public class Armour:Item
    {
        ArmourMaterial Material { get; set; }
        ArmourSlot Slot { get; set; }

        public Armour (int id, string name, string namePlural, ArmourMaterial material,
            ArmourSlot slot):base(id,name,namePlural)
        {
            Material = material;
            Slot = slot;
        }
    }
}
