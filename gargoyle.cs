using System;

namespace Gargoyle
{

class Program
    {
        public class Player
        {
            public string name;
            public int health = 100;
        }
		
        public class Monster
        {
            public string name;
            public int health = 100;
        }

        static void Main(string[] args)
        {
            Player player1 = new Player();
            Monster gargoyle = new Monster();
            gargoyle.name = "Harry the Gargoyle";
            
            Console.WriteLine("You find yourself in a room with a Gargoyle.");
            Console.WriteLine("What do you do?");

            string action = "";
            Random rnd1 = new Random();
            int Damage()
            {
                int attackvalue = rnd1.Next(1, 100);
                return attackvalue;
            }

            while (player1.health > 0 && gargoyle.health > 0)
            {
                Console.WriteLine("Your health: " + player1.health);
                Console.WriteLine("Gargoyle's health: " + gargoyle.health);
                Console.WriteLine("");

                action = Console.ReadLine();
                if (action == "attack")
                {

                    Console.WriteLine("");
                    int playerAttack;
                    playerAttack= Damage();
                    //playerAttack = Damage();
                    Console.WriteLine("You did " + playerAttack + " damage.");
                    gargoyle.health = gargoyle.health - playerAttack;
                    Console.WriteLine("");

                    if (gargoyle.health < 1)
                    {
                        break;
                    }

                    int monsterAttack = Damage();
                    Console.WriteLine("The gargolyle did " + monsterAttack + " damage to you.");
                    Console.WriteLine("");
                    player1.health = player1.health - monsterAttack;


                }
                else
                {
                    Console.WriteLine("You slipped and fell on your ass and the gargoyle ate you.");
                    Console.WriteLine("Try attacking next time.");
                    Console.Read();
                    Console.WriteLine("Thanks for playing.");
                    Console.Read();
                    Console.WriteLine("THE END");
                    Environment.Exit(0);
                }

            }

            if (player1.health < 1)
            {
                Console.WriteLine("Health: " + player1.health);
                Console.WriteLine("You died.");
                Console.Read();
                Console.WriteLine("THE END");
                Environment.Exit(0);
            }

            if (gargoyle.health < 1)
            {
                Console.WriteLine("You killed the gargoyle. Congratulations!");
                Console.WriteLine("Gargoyle health: " + gargoyle.health);
                Console.WriteLine("Your health: " + player1.health);
                Console.Read();
                Console.WriteLine("THE END");
                Environment.Exit(0);
            }

            Console.WriteLine("THE END");
            Console.Read();
        }
        
    }
}
