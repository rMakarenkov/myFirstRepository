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
            int value = rnd.Next(-10,10);
            int x;
            Console.WriteLine("Угадайте число в диапазоне от -10 до 10");

            do
                {
                Console.WriteLine("Введите число:");
                x = Convert.ToInt32(Console.ReadLine());
                if (value == x)
                {
                    Console.WriteLine("Поздравляю, вы угадали число");
                    break;
                }
                else
                {
                    Console.WriteLine("Не угадали!");
                }

            } while (true);
            Console.ReadKey();
        }
    }
}
