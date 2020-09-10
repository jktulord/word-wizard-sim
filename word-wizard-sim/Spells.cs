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
        public string manacost;

    }

    class AllSpells
    {



        public Dictionary<string, Spell> spell_dict = new Dictionary<string, Spell>()
        {

            { "Fire", new Spell { name = "Fire", aspect = "fire", type = "mod", manacost = "10" } },
            { "Water", new Spell { name = "Water", aspect = "water", type = "mod", manacost = "10" } },
            { "Sting", new Spell { name = "Sting", aspect = "phis", type = "main", manacost = "10" } },
            { "Touch", new Spell { name = "Touch", aspect = "phis", type = "main", manacost = "10" } }


        };
    }
}
