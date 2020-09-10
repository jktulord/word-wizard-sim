using System;
using System.Collections.Generic;
using System.Text;

namespace word_wizard_sim
{
    class Enemy
    {
        public int max_hp;
        public int max_mana;
        public int cur_hp;
        public int cur_mana;


        public void Init()
        {
            cur_hp = max_hp;
            cur_mana = max_mana;
        }
    }

    class enemy_dict
    {
        
    }
}
