using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //E-Polling Code Project
            //Jazmen Nabors
            //DVP1
            

            Console.WriteLine("Hello and welcome to our virtual E-polling application.\r\nFirst we are going to start by asking you to please enter in your information below.");
            Console.WriteLine("Full name:");
            string name = Console.ReadLine();

            //validation to see if user left space blank or wrote in their name.
            while (string.IsNullOrWhiteSpace(name)) {
                Console.WriteLine("Please do not leave blank. Please write your full name and press enter.");
                name = Console.ReadLine();
            };
            
            //Checking if user is over 18 or not.
            Console.WriteLine("Are you over the age of 18? Type yes or no.");
            string yesNo = Console.ReadLine();
            if (yesNo == "yes" || yesNo == "Yes")
            {
                Console.WriteLine("DOB:");
                string dobString = Console.ReadLine();


                Console.WriteLine("Please enter in a phone number we can best reach you at.");
                string phoneNumberString = Console.ReadLine();
                int phoneNumber = int.Parse(phoneNumberString);

                Console.WriteLine("E-mail:");
                string email = Console.ReadLine();


            }
            else if(yesNo == "no" || yesNo == "No") {
                Console.WriteLine("You cannot continue any farther. Have a nice day!");
                
            }


        }
    }
}
