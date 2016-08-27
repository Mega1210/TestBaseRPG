using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBaseRPG
{
    abstract class Mods<T>:IMods<T>
    {
        
        public abstract void ModifyStat(T obj, float perc);
        public abstract void ModifyStat(T obj, int amount);
        
        public void AddMod(T obj)
        {

        }
    }
}
