using System;
using System.Collections.Generic;
using System.Text;

namespace word_wizard_sim
{
    public class Spell
    {
        public string name;
        public string aspect;
        public string type;
        public string use_text;
        public int manacost;
        public int dmg;


        public void use(Enemy cur_en, Player pl)
        {
            Console.WriteLine("You hit enemy with "+ use_text + ". Your spell does " + Convert.ToString(this.dmg) + " dmg");
            cur_en.cur_hp -= this.dmg;
            pl.cur_mana -= this.manacost;
        }
    }

    class AllSpells
    {



        public Dictionary<string, Spell> spell_dict = new Dictionary<string, Spell>()
        {

            { "Fire", new Spell { name = "Fire", aspect = "fire", type = "attk", use_text = "Basic Fire", manacost = 10, dmg = 10 } },
            { "Water", new Spell { name = "Water", aspect = "water", type = "attk", use_text = "Basic Water", manacost = 5, dmg = 6 } },
            { "Sting", new Spell { name = "Sting", aspect = "phis", type = "attk", use_text = "Unaspected Sting", manacost = 20, dmg = 12 } },
            { "Touch", new Spell { name = "Touch", aspect = "phis", type = "attk", use_text = "Unaspected Touch", manacost = 1, dmg = 1 } }


        };
    }
}
