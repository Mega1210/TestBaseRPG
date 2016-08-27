using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBaseRPG
{
    class AddHealth:Mods<Player>

    {
        public override void ModifyStat(Player p, int amount)
        {
            p.Health += amount;
        }
        public override void ModifyStat(Player p, float perc)
        {
            
        }
    }
}
