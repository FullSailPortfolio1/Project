using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taco_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Blake Hughes
            //Project & Portfolio
            //Taco Project

            //remove boolean to see if user lost weight or not and just ask how many calories were burned/how many steps were taken

            //add while loop - variable to store data
            //add classes, validation

            //use more food than just taco, add pizza, cheeseburger, etc.
            string foodLove;
            int taco = 156;
            int pizza = 285;
            int burger = 354;
            string userCal;
            int userWeight;

            Console.WriteLine("Press 1 to track weightloss, press 2 to calculate weightloss: ");
            string userInput = Console.ReadLine();
            // loop to make sure user always has an input
            if (userInput == "1")
            {

            }

            else if (userInput == "2")
            {

            //conditional asking if user likes tacos
            Console.WriteLine("Please type in the food you want to calculate, no caps. (taco, pizza, burger)");
            foodLove = Console.ReadLine();

            //if they do like tacos
            if (foodLove == "taco")
            {

                Console.Write("Enter your calories burned in whole numbers:");
                userCal = Console.ReadLine();
                userWeight = Int32.Parse(userCal);

                int totalTaco = userWeight / taco;

                Console.WriteLine("Wow! You burned off " + totalTaco + " tacos!");
            }

            else if (foodLove == "pizza")
            {

                Console.Write("Enter your calories burned in whole numbers:");
                userCal = Console.ReadLine();
                userWeight = Int32.Parse(userCal);

                int totalPizza = userWeight / pizza;

                Console.WriteLine("Wow! You burned off " + totalPizza + " slices of pizza!");
            }


                else if (foodLove == "burger")
                {

                        Console.Write("Enter your calories burned in whole numbers:");
                        userCal = Console.ReadLine();
                        userWeight = Int32.Parse(userCal);

                        int totalBurger = userWeight / burger;

                        Console.WriteLine("Wow! You burned off " + totalBurger + " slices of pizza!");
                    }
                }
            }
        }
    }
