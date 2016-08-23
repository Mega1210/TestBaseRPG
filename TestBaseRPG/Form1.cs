using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBaseRPG
{
    public partial class Form1 : Form
    {
        public Player p;

        public enum ArmourMaterial
        { None, Cloth, Leather, Plate}

        public enum ArmourSlot
        { Head, Body, Feet}

        public Form1()
        {
            InitializeComponent();
        }
        void UpdateStats()
        {
            tb_Name.Text = p.Name;
            tb_Level.Text = p.Level.ToString();
            tb_Health.Text = p.Health.ToString();
            tb_Mana.Text = p.Mana.ToString();
            tb_Strength.Text = p.Strength.ToString();
            tb_Intelligence.Text = p.Intelligence.ToString();
            tb_Dexterity.Text = p.Dexterity.ToString();
            tb_Constitution.Text = p.Constitution.ToString();
            tb_Exp.Text = p.Experience.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Player(1, "Gab", 1, 1, 1, 1, 100, 100,1, 1, 1, 0);

            UpdateStats();
        }

 
    }
}
