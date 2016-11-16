using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Billington_Luke_LogicLoops
{
    //Luke Billington
    //Battlegrounds RPG
    //Creative Commons BY-SA
    //November 6, 2016 - Progress Check
    //DVP1 Course

    class Program
    {
        static void Main(string[] args)
        {

            Graphic.Logo();
            Character[] characters = new Character[6];
            characters[0] = new Character("Dragon             ", "Dragon", "Dragons are wicked legends that not many have seen.They are known for their strength but tire quickly.", 80, 140, 80);
            characters[1] = new Character("Zombie             ", "Zombie", "Zombies once spawned from a mutation gone wrong. They might not be strong, but they're persistent.", 120, 60, 120);
            characters[2] = new Character("Ninja              ", "Ninja", "Ninjas are the stealthiest. You never know when they will strike the hardest.", 120, 80, 100);
            characters[3] = new Character("Alien              ", "Alien", "Not much are known about aliens, but they are pretty steady when it comes to a fight.", 100, 100, 100);
            characters[4] = new Character("Wizard             ", "Wizard", "Wizards are zainy. They might not be strong, but they certainly have logic on their side.", 130, 60, 110);
            characters[5] = new Character("Pirate             ", "Pirate", "Pirates have roamed the seven seas for years. They know when to strike and strike hard.", 60, 120, 120);

            bool quit = false;

            while(quit == false)
            {
                Game game = new Game(characters);
                game.Play();
                game.Results();
                Console.WriteLine("Press the Y key to play again.");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar != 'y')
                {
                    quit = true;
                }
            }

        }

    }
}
