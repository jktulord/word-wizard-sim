using System;
using System.Collections.Generic;
using System.Text;

namespace word_wizard_sim
{
    class Enemy
    {
        public string name;
        public int max_hp;
        public int cur_hp;
        public int dmg;
        public string attk_text;


        public void restore()
        {
            cur_hp = max_hp;
            cur_mana = max_mana;
        }
        public void attack(Player pl)
        {
            Console.WriteLine(this.name + attk_text + Convert.ToString(dmg) + "dmg");
            pl.cur_hp -= this.dmg;
        }
    }

    class Enemies
    {
        public Enemy rat = new Enemy{name = "Rat", max_hp = 20, dmg = 5, attk_text = "bites you and does "};
    }
}
