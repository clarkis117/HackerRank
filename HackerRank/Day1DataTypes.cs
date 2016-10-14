using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
	class Day1DataTypes
	{
		static void Main(string[] args)
		{
			int i = 4;
			double d = 4.0;
			string s = "HackerRank ";

			// Declare second integer, double, and String variables.
			int secondInt = 0;
			double secondDouble = 0;
			string secondString;

			// Read and save an integer, double, and String to your variables.
			var integer = Console.ReadLine();

			secondInt = Convert.ToInt32(integer);

			var doubleString = Console.ReadLine();

			secondDouble = Convert.ToDouble(doubleString);

			secondString  = Console.ReadLine();

			// Print the sum of both integer variables on a new line.
			Console.WriteLine(i + secondInt);

			// Print the sum of the double variables on a new line.
			double sum = d + secondDouble;

			Console.WriteLine(sum.ToString("n1"));

			// Concatenate and print the String variables on a new line
			// The 's' variable above should be printed first.
			Console.WriteLine(s + secondString);
		}
	}
}
