using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingtheCodingInterview
{
	public class StringsMakingAnagrams
	{
		static void Main(String[] args)
		{
			string a = Console.ReadLine();
			string b = Console.ReadLine();

			//counting array since we're dealing with characters a-z
			int[] counts = new int[26];
			char letterA = 'a';

			char[] charArray = a.ToCharArray();

			//iterate through a and get the count of each letter in the keyspace a-z
			for (int i = 0; i < charArray.Length; i++) {
				counts[charArray[i] - letterA]++;
			}

			charArray = b.ToCharArray();

			//iterate through b and decrement the count for each letter that occurs in b
			for (int i = 0; i < charArray.Length; i++) {
				counts[charArray[i] - letterA]--;
			}

			//if the count is zero the letters occur in equal freqency in both string a and b
			//if the count is not zero then those letters need deleted

			int sum = 0;

			//sum all values in counts to get the number of characters that prevent the strings
			//from being anagrams
			for (int i = 0; i < counts.Length ; i++){
				sum += Math.Abs(counts[i]);
			}

			Console.WriteLine(sum);
		}
	}
}
