using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billington_Luke_LogicLoops
{
    class Graphic
    {
        //This class uses static functions to keep the program file clean.

        //Logo
        public static void Logo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n\r\n\r\n\t__________         __    __  .__                                               .___      ");
            Console.WriteLine("\t\\______   \\_____ _/  |__/  |_|  |   ____   ___________  ____  __ __  ____    __| _/______");
            Console.WriteLine("\t |    |  _/\\__  \\    __\\   __\\  | _/ __ \\ / ___\\_  __ \\/  _ \\|  |  \\/    \\  / __ |/  ___/");
            Console.WriteLine("\t |    |   \\ / __ \\|  |  |  | |  |_\\  ___// /_/  >  | \\(  <_> )  |  /   |  \\/ /_/ |\\___ \\ ");
            Console.WriteLine("\t |______  /(____  /__|  |__| |____/\\___  >___  /|__|   \\____/|____/|___|  /\\____ /____  >");
            Console.WriteLine("\t        \\/      \\/                     \\/_____/                         \\/      \\/    \\/\r\n");
            Console.WriteLine("\tBy LukeCreative\r\n\r\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tPress any key to fight . . .");
            Console.ReadKey();
            Console.Clear();
        }

        //Divider
        public static void Divider()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }

        //Spacer
        public static void Spacer()
        {
            Console.Write("                                                               ");
        }

        //Paginate
        public static void Paginate(int size, int selected = -1)
        {
            int i = 0;
            while (i < size)
            {
                if (selected == i)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                Console.Write(" {0} ", i + 1);
                Console.ResetColor();
                i++;
            }
        }

        //Status Bar
        public static void StatusBar(int value, int type = 0)
        {
            //0 = health
            //1 = damage
            //2 = energy
            int bars = value / 10;
            if (type == 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (type == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (type == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            //Counter
            int counter = 0;
            while (counter < bars)
            {
                Console.Write("|");
                counter++;
            }
            while (counter < 15)
            {
                Console.Write(" ");
                counter++;
            }
            Console.ResetColor();
            if (value < 0)
            {
                value = 0;
            }

            if (value >= 100)
            {
                Console.Write(" " + value);
            }
            else if (value >= 10 && value < 100)
            {
                Console.Write("  " + value);
            }
            else
            {
                Console.Write("   " + value);
            }
        }

        //Score Bar
        public static void ScoreBar(Player player1, Player player2, int round, int stage = 0)
        {
            Console.ResetColor();
            Console.Clear();
            Console.Write("Player: ");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write(player1.GetDisplay());
            Console.ResetColor();
            Graphic.Spacer();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(player2.GetDisplay());
            Console.ResetColor();
            Console.Write("\r\nHealth: ");
            Graphic.StatusBar(player1.GetHealth(), 0);
            Graphic.Spacer();
            Graphic.StatusBar(player2.GetHealth(), 0);
            Console.Write("\r\nEnergy: ");
            Graphic.StatusBar(player1.GetEnergy(), 2);
            Graphic.Spacer();
            Graphic.StatusBar(player2.GetEnergy(), 2);
            Console.Write("\r\n");
            Graphic.Divider();
            Console.Write("Round {0}: ", round);
            if (stage == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.Write(" Roll ");
            Console.BackgroundColor = ConsoleColor.Black;
            if (stage == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.Write(" Move ");
            Console.BackgroundColor = ConsoleColor.Black;
            if (stage == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.Write(" Attack ");
            Console.ResetColor();
            Console.Write("\r\n");
            Graphic.Divider();
        }

        //Roll
        public static void Roll(int roll1, int roll2)
        {

            roll1 -= 1;
            roll2 -= 1;
            int i = 0;

            string[][] dice = {
                new string[5] { "           ", "           ", "     +     ", "           ", "           " },
                new string[5] { "           ", "  +        ", "           ", "        +  ", "           " },
                new string[5] { "           ", "  +        ", "     +     ", "        +  ", "           " },
                new string[5] { "           ", "  +     +  ", "           ", "  +     +  ", "           " },
                new string[5] { "           ", "  +     +  ", "     +     ", "  +     +  ", "           " },
                new string[5] { "           ", "  +     +  ", "  +     +  ", "  +     +  ", "           " }
            };

            while (i < 5)
            {
                Console.Write("            ");
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Write(dice[roll1][i]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("    ");
                Graphic.Spacer();
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(dice[roll2][i]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("    ");
                Console.Write("\r\n");
                i++;
            }
            Graphic.Divider();
        }

        //Board Center
        public static void BoardCenter()
        {
            Console.Write("\r\n                          ");
        }

        //Board
        public static void Board(Player player1, Player player2, int shrink = 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int size = 12;
            int min = 0 + shrink;
            int max = size - shrink;
            int x = 0;
            int y = 0;
            //Draw top line.
            Graphic.BoardCenter();
            Console.Write("+");
            while (x < size)
            {
                Console.Write("---+");
                x++;
            }
            Graphic.BoardCenter();
            //Draw rows.
            while (y < size)
            {
                //Draw left line.
                Console.Write("|");

                //Draw boxes.
                x = 0;
                while (x < size)
                {
                    if (x == player1.GetX() && y == player1.GetY() && x == player2.GetX() && y == player2.GetY())
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("{0}", player1.GetName().ToCharArray()[0]);
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write("{0}", player2.GetName().ToCharArray()[0]);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("|");
                    }
                    else if (x == player1.GetX() && y == player1.GetY())
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" {0} ", player1.GetName().ToCharArray()[0]);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("|");
                    }
                    else if (x == player2.GetX() && y == player2.GetY())
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" {0} ", player2.GetName().ToCharArray()[0]);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("|");
                    }
                    else if (x < min || x >= max || y < min || y >= max)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write("   ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                    x++;
                }

                Graphic.BoardCenter();

                //Draw left dot.
                Console.Write("+");

                //Draw bottom lines.
                x = 0;
                while (x < size)
                {
                    Console.Write("---+");
                    x++;
                }

                Graphic.BoardCenter();
                y++;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Victory
        public static void Victory()
        {
            Console.WriteLine("\r\n\r\n\r\n\t____   ____.__        __                       ");
            Console.WriteLine("\t\\   \\ /   /|__| _____/  |_  ___________ ___.__.");
            Console.WriteLine("\t \\   Y   / |  |/ ___\\   __\\/  _ \\_  __ <   |  |");
            Console.WriteLine("\t  \\     /  |  \\  \\___|  | (  <_> )  | \\/\\___  |");
            Console.WriteLine("\t   \\___/   |__|\\___  >__|  \\____/|__|   / ____|");
            Console.WriteLine("\t                   \\/                   \\/     \r\n");
        }

        //Defeat
        public static void Defeat()
        {
            Console.WriteLine("\r\n\r\n\r\n\t________          _____              __   ");
            Console.WriteLine("\t\\______ \\   _____/ ____\\____ _____ _/  |_ ");
            Console.WriteLine("\t |    |  \\_/ __ \\   __\\/ __ \\__   \\    __\\");
            Console.WriteLine("\t |    `   \\  ___/|  | \\  ___/ / __ \\|  |  ");
            Console.WriteLine("\t/_______  /\\___  >__|  \\___  >____  /__|  ");
            Console.WriteLine("\t        \\/     \\/          \\/     \\/      \r\n");
        }

    }
}
