using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace word_wizard_sim
{
    class Player
    {
        public int max_mana = 100;
        public int max_hp = 100;
        public int cur_mana = 100;
        public int cur_hp = 100;

        public void restore()
        {
            cur_hp = max_hp;
            cur_mana = max_hp;
        }
    }
}
