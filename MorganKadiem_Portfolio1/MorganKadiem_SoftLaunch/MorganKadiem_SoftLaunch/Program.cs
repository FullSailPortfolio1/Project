using System;
using System.Collections.Generic;

namespace Morgan_Kadiem_lab10
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Kadiem D. Morgan
			// SDI 1601
			// Lottery Simulator

			List<int> randomArray;
			string userInput = "";
			int lottoNum = 5;
			int floridaNum = 6;
			string inputNum1 = "";
			string inputNum2 = "";
			string inputNum3 = "";
			string inputNum4 = "";
			string inputNum5 = "";
			string inputNum6 = "";

			while (userInput != "Powerball" && userInput != "Florida")
			{

				Console.WriteLine("Do you want to generate Powerball numbers or Florida Lottery numbers?");
				Console.WriteLine("Enter Powerball or Florida");
				userInput = Console.ReadLine();

			}

			if (userInput == "Powerball")
			{
				Console.WriteLine("Numbers 1 - 99");
				Console.WriteLine("Enter your first number: ");
				inputNum1 = Console.ReadLine();
				while (inputNum1.Length >= 3)
				{
					Console.WriteLine("Enter your first number: ");
					inputNum1 = Console.ReadLine();
				}
				Console.WriteLine("Enter your second number: ");
				inputNum2 = Console.ReadLine();
				while (inputNum2.Length >= 3)
				{
					Console.WriteLine("Enter your second number: ");
					inputNum2 = Console.ReadLine();
				}
				Console.WriteLine("Enter your third number: ");
				inputNum3 = Console.ReadLine();
				while (inputNum3.Length >= 3)
				{
					Console.WriteLine("Enter your third number: ");
					inputNum3 = Console.ReadLine();
				}
				Console.WriteLine("Enter your fourth number: ");
				inputNum4 = Console.ReadLine();
				while (inputNum4.Length >= 3)
				{
					Console.WriteLine("Enter your fourth number: ");
					inputNum4 = Console.ReadLine();
				}
				Console.WriteLine("Enter your fifth number: ");
				inputNum5 = Console.ReadLine();
				while (inputNum5.Length >= 3)
				{
					Console.WriteLine("Enter your fifth number: ");
					inputNum5 = Console.ReadLine();
				}
				Console.WriteLine("Your numbers are " + inputNum1 + " " + inputNum2 + " " + inputNum3
								  + " " + inputNum4 + " " + inputNum5);

				randomArray = lottoPicks(lottoNum);
				Console.WriteLine("The winning numbers are ");

				for (int i = 0; i < randomArray.Count; i++)
				{

					Console.Write(randomArray[i] + ", ");
					Console.WriteLine("Did you win?");

				}

				Random ball = new Random();

				List<int> result = new List<int>();

				HashSet<int> check = new HashSet<int>();

				for (int i = 0; i < 6; i++)
				{
					int value = ball.Next(1, 10);
					while (check.Contains(value))
					{

						value = ball.Next(1, 10);

					}
					result.Add(value);
					check.Add(value);

					Console.Write(value + ", ");

				}

			}

			else if (userInput == "Florida")
			{
				Console.WriteLine("Numbers 1 - 99");
				Console.WriteLine("Enter your first number: ");
				inputNum1 = Console.ReadLine();
				while (inputNum1.Length >= 3)
				{
					Console.WriteLine("Enter your first number: ");
					inputNum1 = Console.ReadLine();
				}
				Console.WriteLine("Enter your second number: ");
				inputNum2 = Console.ReadLine();
				while (inputNum2.Length >= 3)
				{
					Console.WriteLine("Enter your second number: ");
					inputNum2 = Console.ReadLine();
				}
				Console.WriteLine("Enter your third number: ");
				inputNum3 = Console.ReadLine();
				while (inputNum3.Length >= 3)
				{
					Console.WriteLine("Enter your third number: ");
					inputNum3 = Console.ReadLine();
				}
				Console.WriteLine("Enter your fourth number: ");
				inputNum4 = Console.ReadLine();
				while (inputNum4.Length >= 3)
				{
					Console.WriteLine("Enter your fourth number: ");
					inputNum4 = Console.ReadLine();
				}
				Console.WriteLine("Enter your fifth number: ");
				inputNum5 = Console.ReadLine();
				while (inputNum5.Length >= 3)
				{
					Console.WriteLine("Enter your fifth number: ");
					inputNum5 = Console.ReadLine();
				}
				Console.WriteLine("Enter your sixth number: ");
				inputNum6 = Console.ReadLine();
				while (inputNum6.Length >= 3)
				{
					Console.WriteLine("Enter your sixth number: ");
					inputNum6 = Console.ReadLine();
				}
				Console.WriteLine("Your numbers are " + inputNum1 + " " + inputNum2 + " " + inputNum3
								  + " " + inputNum4 + " " + inputNum5 + " " + inputNum6);

				randomArray = lottoPicks(floridaNum);
				Console.WriteLine("The winning numbers are ");

				for (int i = 0; i < randomArray.Count; i++)
				{

					Console.Write(randomArray[i] + ", ");
					Console.WriteLine("Did you win?");

				}
			}
		}

		public static List<int> lottoPicks(int randomNum)
		{

			Random lottoBalls = new Random();

			List<int> result = new List<int>();

			HashSet<int> check = new HashSet<int>();

			for (int i = 0; i < randomNum; i++)
			{

				int currentValue = lottoBalls.Next(1, 50);

				while (check.Contains(currentValue))
				{

					currentValue = lottoBalls.Next(1, 50);

				}
				result.Add(currentValue);
				check.Add(currentValue);

			}

			return result;

		}
	}
}