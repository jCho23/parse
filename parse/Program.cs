using System;

namespace parse
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			Console.Write("Please enter your age:");
			string yourAge = Console.ReadLine();

			int yourAgeAsInt = int.Parse(yourAge);
			yourAgeAsInt += 1;

			Console.WriteLine("Your age is {0}", yourAgeAsInt.ToString());











		}



	}
}
