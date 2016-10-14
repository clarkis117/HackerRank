using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingtheCodingInterview
{
	class ArrayLeftRotate
	{
		static void Main(string[] args)
		{
			string[] tokens_n = Console.ReadLine().Split(' ');

			int length = Convert.ToInt32(tokens_n[0]);

			int rotations = Convert.ToInt32(tokens_n[1]);

			string[] a_temp = Console.ReadLine().Split(' ');

			int[] a = Array.ConvertAll(a_temp, Int32.Parse);

			//output array
			for (int i = 0; i < length; i++)
				Console.Write( a[(i + rotations) % length] + " ");
		}

		public int[] MethodRank(int[] array, int rotations)
		{
			int[] tempArray = new int[array.Length]; //this is the array we'll output

			int kIndex = 0;

			//begin array copy at index specified by rotations
			for (int i = rotations; i < array.Length; i++, kIndex++)
				tempArray[kIndex] = array[i];

			int j = 0;


			for (int bIndex = kIndex; bIndex < array.Length; bIndex++, j++)
				tempArray[bIndex] = array[j];

			return tempArray;
		}
	}
}
