using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBaseRPG
{
    abstract class Weapon : Item
    {
        public int MinDMG { get; set; }
        public int MaxDMG { get; set; }
        public float APS { get; set; }
        public List<Mods<Weapon>> AllowedMods {get;set;}

        public Weapon (int id, string name, string namePlural):base(id,name,namePlural)
        {
            AllowedMods.Add(new AttackSpeed());
            AllowedMods.Add(new AddHealth());
        }

        public abstract int GiveTier(int tier);
        public abstract float GiveAps();
        public abstract int GiveMinDMG(int tier);
        public abstract int GiveMaxDMG(int tier);
    }
}
