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
            en.Init();
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
                    String s = Console.ReadLine();
                    String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length == 1)
                    {
                        try {
                            Spell current = all_spells.spell_dict[words[1]];
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        
                    }
                }
            
                
                
            }
        }
    }
}
