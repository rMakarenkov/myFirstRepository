using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.String
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int counterDelete = 0;
			int temp = 0;
			Console.WriteLine("Введите предложение с двойными пробелами!");
			string original = Console.ReadLine();
			Console.WriteLine("Вы написали: \n{0}", original);
			List<char> list = original.ToList();

			for (int j = 0; j < list.Count; j++)
			{
				for (int i = 0; i < list.Count; i++)
				{
					temp++;
					if (list[i] == ' ')
					{
						if (list[i] == list[i + 1])
						{
							list.RemoveAt(i + 1);
							counterDelete++;
						}
					}
				}
			}

			Console.WriteLine($"Количество символов в строке {original.Length}");
			Console.WriteLine($"Количество проходов = {temp}");

			Console.WriteLine("За все итерации преобразовано двойных пробелов = {0} \n\nУдалим двойные пробелы и получим " +
				"следующий результат:", counterDelete);

			Console.WriteLine($"\"{new string(list.ToArray())}\"");

			Console.ReadKey();


		}
	}
}
