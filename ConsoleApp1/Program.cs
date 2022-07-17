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
			int[] array = new int[] {-7, 1, 5, 2, -4, 3, 0 };
			int leftSum = array[0];
			int rightSum = array.Skip(2).Sum();
			int iterationCount = 1;
			int temp = 0;

			if (leftSum == rightSum)
			{
				Console.WriteLine($"Элемент массива с равнозначной суммой левой и правой частей массива = {iterationCount}");
				Console.ReadKey();
			}
			else
			{
				for (int i = 2; i < array.Length; i++)
				{
					temp++;
					iterationCount++;
					leftSum += array[i - 1];
					rightSum -= array[iterationCount];

					if (leftSum == rightSum)
					{
						Console.WriteLine($"Элемент массива с равнозначной суммой левой и праввой частей массива = {iterationCount}");
						Console.WriteLine($"Количество итераций = {temp}");
						break;
					}
				}
			}

			Console.ReadKey();
		}
	}
}
