using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[] { -7, 1, 5, 2, -4, 3, 0};
			int leftSum = 0;
			int rightSum = 0;
			int iterationCount = 0;

			for (int k = 1; k < array.Length-1; k++)
			{
				leftSum = 0;
				rightSum = 0;
				iterationCount++;

				for (int i = 0; i < k; i++)
				{
					leftSum += array[i];
				}

				for (int j = array.Length - 1; j > k; j--)
				{
					rightSum += array[j];
				}

				if (leftSum == rightSum)
				{
					Console.WriteLine("Элемент массива с равнозначной суммой левой и праввой частей массива = {0}", iterationCount);
					break;
				}
			}

			
			Console.ReadKey();
		}
	}
}
