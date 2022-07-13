using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int left = 0;
			int right = 100;
			int value = rnd.Next(left, right);
			int attempt = 5;
			Console.WriteLine($"Угадайте число в диапазоне от {left} до {right}");

			do
			{
				Console.WriteLine($"Введите число, у вас осталось {attempt} попыток ");
				int userInput = Convert.ToInt32(Console.ReadLine());
				
				if (value == userInput)
				{
					Console.WriteLine("Поздравляю, вы угадали число");
					break;
				}
				else
				{
					Console.WriteLine("Не угадали!");
				}

				attempt--;

				if (userInput < value)
				{
					Console.WriteLine("Число загадано больше");
				}
				else
				{
					Console.WriteLine("Число загадано меньше");
				} 

				if (attempt <= 0)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Количество попыток исчерпано!");
					break;
				}

			} while (true);

			Console.ReadKey();
		}
	}
}
