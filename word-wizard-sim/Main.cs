using System;

namespace word_wizard_sim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Player pl = new Player();
            Enemy en = new Enemy { max_hp = 10};
            AllSpells all_spells = new AllSpells();
            en.restore();
            Console.WriteLine("bNTBA");
            string state = "yturn";

            Boolean exit = false;
            while (exit == false)
            {
                Console.Clear();
                Console.WriteLine("Your Hp", Convert.ToString(pl.max_hp));
                Console.WriteLine("Your mana", Convert.ToString(pl.max_mana));
                Console.WriteLine("Enemy Hp", Convert.ToString(pl.max_hp));


                if (state == "yturn")
                {
                    Console.WriteLine("<Your turn>");
                    Console.WriteLine("Write your spell");
                    
                }
                if (state == "enturn")
                {
                    Console.WriteLine("<Enemy turn>");
                    Console.WriteLine("Write anything to continue");
                    
                }

                String s = Console.ReadLine();
                String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (state == "yturn")
                {
                    Console.WriteLine("<Your turn>");
                    
                    if (words.Length == 1)
                    {
                        Spell cur_spell = all_spells.spell_dict[words[0]];
                        cur_spell.use(en, pl);
                    }
                    state = "enturn";
                }
                
                else if (state == "enturn")
                {
                    Console.WriteLine("Enemy does nothing");
                    en.attack(pl);
                    state = "yturn";
                }   
                
                cki = Console.ReadKey();
                
                
            }
        }
    }
}
