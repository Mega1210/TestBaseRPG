using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestBaseRPG.Form1;


namespace TestBaseRPG
{
    class Sword:Weapon
    {
       const int L_MIN = 1;
        const int INCREMEMTS = 10;
        const int L_MAX = 21;
        const float MIN_APS = 1.2f;
        const float MAX_APS = 2.0f;
        
        public Sword(int id, string name, string namePlural):base(id, name, namePlural)
        {
            
        }

        public override int GiveTier(int tier)
        {
            return rnd.Next(1, tier + 1);
        }

        public override int GiveMinDMG(int tier)
        {
            return rnd.Next(L_MIN + (INCREMEMTS * (tier - 1)), L_MIN + (INCREMEMTS * (tier - 1)) + INCREMEMTS);
        }

        public override int GiveMaxDMG(int tier)
        {
            return rnd.Next(L_MAX + (INCREMEMTS * (tier - 1)), L_MAX + (INCREMEMTS * (tier - 1) + INCREMEMTS));
        }

        public override float GiveAps()
        {
            return (float) rnd.Next((int)MIN_APS * 10, (int)MAX_APS * 10 + 1)/10;
        }
    }
}
