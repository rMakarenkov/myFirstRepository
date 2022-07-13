using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double x1;
			double x2;
			double D;
			Console.WriteLine("Решите квадратное уравнение ax^2+bx+c = 0");
			Console.WriteLine("Введите a = ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите b = ");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите с = ");
			double c = Convert.ToDouble(Console.ReadLine());

			if (a == 0)
			{
				if (b == 0)
				{
					if (c == 0)
					{
						Console.WriteLine("Для любых значений Х выполняется условие уравнения");

					}
					else
					{
						Console.WriteLine("Ложные данные");
					}
				}
				else
				{
					Console.WriteLine("Это не квадратное уравнение, решаем {0}x + {1} = 0", b, c);
					x1 = -c / b;
					Console.WriteLine("Решение x = {0}", x1);
				}

			}
			else
			{
				Console.WriteLine("Решаем уравнение: {0}x^2 + {1}x + {2} = 0", a, b, c);
				D = b * b - 4 * a * c;
				if (D < 0)
				{
					Console.WriteLine("Действительных корнгей нет");
				}
				else
				{
					x1 = (-b + Math.Sqrt(D)) / 2 * a;
					x2 = (-b - Math.Sqrt(D)) / 2 * a;
					Console.WriteLine("Корни квадратного уравнения: \nx1 = {0};\nx2 = {1}", x1, x2);
				}
			}

			Console.ReadKey();


		}
	}
}
