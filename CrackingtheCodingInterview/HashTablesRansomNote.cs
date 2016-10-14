using System;
using System.Collections;
using System.Collections.Generic;

namespace CrackingtheCodingInterview
{
	public class HashTablesRansomNote
	{
		static void Main(String[] args)
		{
			string[] tokens_m = Console.ReadLine().Split(' ');
			int m = Convert.ToInt32(tokens_m[0]);
			int n = Convert.ToInt32(tokens_m[1]);
			string[] magazine = Console.ReadLine().Split(' ');
			string[] ransom = Console.ReadLine().Split(' ');

			if (magazine.Length < ransom.Length)
			{
				Console.WriteLine("No");
				return;
			}

			var hashtable = new Dictionary<string, int>();

			for (int i = 0; i < magazine.Length; i++)
			{
				var word = magazine[i];

				if (!hashtable.ContainsKey(word))
				{
					hashtable.Add(word, 1);
				}
				else
				{
					hashtable[word]++;
				}
			}

			int counter = 0;

			for (int i = 0; i < ransom.Length; i++)
			{
				if (hashtable[ransom[i]] >= 1)
				{
					counter++;

					hashtable[ransom[i]]--;
				}
			}

			Console.WriteLine(counter >= n ? "Yes" : "No");
		}
	}
}