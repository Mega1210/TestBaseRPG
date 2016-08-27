using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBaseRPG
{
    class AttackSpeed:Mods<Weapon>
    {
        public override void ModifyStat(Weapon w, float perc)
        {
            w.APS = w.APS * (1 + perc);
           
        }

        public override void ModifyStat(Weapon obj, int amount)
        {
            
        }

        
    }
}
