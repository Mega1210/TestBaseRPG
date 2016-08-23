using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBaseRPG
{
    public class Creature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Strength { get; set; }
        public byte Dexterity { get; set; }
        public byte Intelligence { get; set; }
        public byte Constitution { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Gold { get; set; }
        public byte Level { get; set; }

        public Creature (int id, string name, byte str, byte inte, byte dex, byte cons, byte health, byte mana, byte lvl)
        {
            ID = id;
            Name = name;
            Strength = str;
            Dexterity = dex;
            Intelligence = inte;
            Constitution = cons;
            Health = health;
            Mana = mana;
            Level = lvl;
        }
    }
}
