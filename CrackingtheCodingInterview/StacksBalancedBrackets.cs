using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingtheCodingInterview
{
	class StacksBalancedBrackets
	{
		static void Main(String[] args)
		{

			

			int t = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < t; a0++)
			{
				string expression = Console.ReadLine();

				var expressionCharArray = expression.ToCharArray();

				int squareBracketCount = 0, angleBracketCount = 0, parentheses = 0;

				for (int i = 0; i < expressionCharArray.Length; i++)
				{
					switch (expressionCharArray[i])
					{
						case '{':
							angleBracketCount++;
							break;
						case '}':
							angleBracketCount--;
							break;
						case '[':
							squareBracketCount++;
							break;
						case ']':
							squareBracketCount--;
							break;
						case '(':
							parentheses++;
							break;
						case ')':
							parentheses--;
							break;

						default:
							break;
					}
				}

				if (squareBracketCount == 0 && angleBracketCount == 0 && parentheses == 0)
				{
					Console.WriteLine("Yes");
				}
				else
				{
					Console.WriteLine("No");
				}
			}
		}
	}
}
