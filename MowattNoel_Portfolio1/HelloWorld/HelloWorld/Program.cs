using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //--prompt user for name
            Console.WriteLine("Enter your name: ");

            //--Stores user's name
            string nameIn = Console.ReadLine();

            //--Method Call
            //--Greets user by name when nameIn is passed as an argument
            var greet = Greeting(nameIn);

            //--Output
            Console.WriteLine(greet);
        }

        //--Method
        static string Greeting(string name)
        {

            return ("Hello "+name+"!");
        }
    }
}
