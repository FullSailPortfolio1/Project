using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Billington_Luke_LogicLoops
{
    class View
    {

        public static int ChooseCharacter(Character[] characters)
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("\r\nChoose your fighter type!\r\n");
            Graphic.Divider();
            Console.WriteLine("\r\nType a number 1-{0} to view the types of fighters, when you have found the one you want, press space.\r\n", characters.Length);
            Graphic.Divider();
            Console.Write("\r\nFighters: ");
            Graphic.Paginate(characters.Length);
            Console.WriteLine("\r\n");

            int character = 0;
            bool chosen = false;
            while(chosen == false)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.KeyChar == ' ')
                {
                    chosen = true;
                } else
                {
                    int i = 0;
                    while (i < characters.Length)
                    {
                        char keyPress = key.KeyChar;
                        int keyNumber = (int)char.GetNumericValue(keyPress);
                        if(keyNumber == i + 1)
                        {
                            character = i;
                            View.CharacterStats(characters, character);
                        }
                        i++;
                    }
                }
            }
            return character;
        }

        public static void CharacterStats(Character[] characters, int selected)
        {
            Console.Clear();
            Character character = characters[selected];

            Console.WriteLine("\r\n" + character.GetDisplay() + "\r\n");
            Graphic.Divider();
            Console.WriteLine("\r\n" + character.GetBio() + "\r\n");
            Graphic.Divider();
            Console.Write("\r\nHealth: ");
            Graphic.StatusBar(character.GetBaseHealth(), 0);
            Console.Write(" Affected negatively when hit by opponent.");
            Console.Write("\r\nDamage: ");
            Graphic.StatusBar(character.GetBaseDamage(), 1);
            Console.Write(" Multiplier of damage afflicted to opponent.");
            Console.Write("\r\nEnergy: ");
            Graphic.StatusBar(character.GetBaseEnergy(), 2);
            Console.Write(" Affected negatively when hittting opponent.");
            Console.WriteLine("\r\n");
            Graphic.Divider();
            Console.Write("\n\rFighters: ");
            Graphic.Paginate(characters.Length, selected);
            Console.WriteLine("\r\n");
            Graphic.Divider();
            Console.WriteLine("\r\nPress space to choose!\r\n");
        }

        public static void Opponent(Player player1, Player player2)
        {
            Console.Clear();
            Console.WriteLine("\r\nIt's time to fight!\r\n");
            Graphic.Divider();

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\r\n\t" + player1.GetDisplay() + "   (You)\t\t\t\t\t\t\t\t\t\t     \r\n");
            Console.ResetColor();
            Console.Write("\r\n\tHealth: ");
            Graphic.StatusBar(player1.GetBaseHealth(), 0);
            Console.Write("\r\n\tDamage: ");
            Graphic.StatusBar(player1.GetBaseDamage(), 1);
            Console.Write("\r\n\tEnergy: ");
            Graphic.StatusBar(player1.GetBaseEnergy(), 2);

            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n\tVS\r\n");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\r\n\t" + player2.GetDisplay() + "\t\t\t\t\t\t\t\t\t\t\t     \r\n");
            Console.ResetColor();
            Console.Write("\r\n\tHealth: ");
            Graphic.StatusBar(player2.GetBaseHealth(), 0);
            Console.Write("\r\n\tDamage: ");
            Graphic.StatusBar(player2.GetBaseDamage(), 1);
            Console.Write("\r\n\tEnergy: ");
            Graphic.StatusBar(player2.GetBaseEnergy(), 2);
            Console.WriteLine("\r\n");
            Graphic.Divider();
            Console.WriteLine("\r\nPress any key to fight. . .");
            Console.ReadKey();
        }

        public static void Roll(Player player1, Player player2, int round, int shrink = 0)
        {
            Graphic.ScoreBar(player1, player2, round, 1);
            Graphic.Roll(player1.GetRoundRoll(), player2.GetRoundRoll());
            Console.Write("\r\n");
            Console.WriteLine("You rolled a {0} while the {1} rolled a {2}. You can move {0} space(s).", player1.GetRoundRoll(), player2.GetName(), player2.GetRoundRoll());
            Console.Write("\r\n");
            Graphic.Divider();
            Console.WriteLine("\r\nPress any key to advance and make your move.");
            Console.ReadKey();
            
        }

        public static void Move(Player player1, Player player2, int round, int shrink = 0)
        {
            int moves = 0;
            int min = 0 + shrink;
            int max = 11 - shrink;

            while (moves < player1.GetRoundRoll())
            {

                int x = player1.GetX();
                int y = player1.GetY();
                if(x < min)
                {
                    player1.SetX(min);
                }
                if (x > max)
                {
                    player1.SetX(max);
                }
                if (y < min)
                {
                    player1.SetY(min);
                }
                if (y > max)
                {
                    player1.SetY(max);
                }
                Graphic.ScoreBar(player1, player2, round, 2);
                Graphic.Roll(player1.GetRoundRoll(), player2.GetRoundRoll());
                Console.WriteLine("\t Moves: {0}/{1}", moves, player1.GetRoundRoll());
                Graphic.Divider();
                Graphic.Board(player1, player2, shrink);
                Console.Write("\r\n");
                Graphic.Divider();
                Console.WriteLine("\r\nUse the W, A, S, and D keys to move across the board.");

                bool moved = false;
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.KeyChar == 'w')
                {
                    y--;
                    moved = true;
                } else if(key.KeyChar == 's')
                {
                    y++;
                    moved = true;
                } else if(key.KeyChar == 'a')
                {
                    x--;
                    moved = true;
                } else if(key.KeyChar == 'd')
                {
                    x++;
                    moved = true;
                }

                if(moved == true && x >= min && x <= max && y >= min && y <= max)
                {
                    player1.SetX(x);
                    player1.SetY(y);
                    moves++;
                }

            }

            Graphic.ScoreBar(player1, player2, round, 2);
            Graphic.Roll(player1.GetRoundRoll(), player2.GetRoundRoll());
            Graphic.Board(player1, player2, shrink);
            Console.Write("\r\n");
            Graphic.Divider();
        }

        public static void Attack(Player player1, Player player2, int round, int shrink = 0)
        {
            Graphic.ScoreBar(player1, player2, round, 3);
            Console.Write("\r\n");
            Console.WriteLine(player2.GetRoundMessage());
            Console.WriteLine(player1.GetRoundMessage());
            Console.Write("\r\n");
            Graphic.Divider();
            Graphic.Board(player1, player2, shrink);
            Console.Write("\r\n");
            Graphic.Divider();
            Console.WriteLine();
            Console.WriteLine("\r\nPress any key to advance to the next round.");
            Console.ReadKey();
        }

        public static void Winner(Player player1, Player player2, bool win, int round)
        {
            Console.Clear();
            Graphic.ScoreBar(player1, player2, round);
            if (win == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Graphic.Victory();
                Console.WriteLine("\r\n\tYou defeated the {0} in {1} rounds!\r\n", player2.GetName(), round);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Graphic.Defeat();
                Console.WriteLine("\r\n\tYou were defeated by the {0} in {1} rounds!\r\n", player2.GetName(), round);
                Console.ResetColor();
            }
        }

    }
}
