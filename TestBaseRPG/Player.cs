using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBaseRPG
{
    public class Player:Creature
    {
        public float HP_regen { get; set; }
        public float Mana_regen { get; set; }
        public int Experience { get; set; }
        

        public Player (int id, string name, byte str, byte inte, byte dex, byte cons, byte health, byte mana, byte lvl,
            float HPreg, float manaReg, int exp):base(id, name, str, inte, dex, cons, health, mana, lvl)
        {
            HP_regen = HPreg;
            Mana_regen = manaReg;
            Experience = exp;
        }
    }
}
