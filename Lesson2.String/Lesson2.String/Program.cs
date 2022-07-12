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
            string s1;
            int temp = 0;
            int k = 0;
            Console.WriteLine("Введите предложение с двойными пробелами!");
            s1 = Console.ReadLine();
            Console.WriteLine("Вы написали: \n{0}", s1);
            List<char> list = new List<char> { };

            foreach(var c in s1)
            {
                list.Add(c);
            }

            for (int j = 0; j < list.Count; j++) 
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == ' ')
                    {
                        if (list[i] == list[i + 1])
                        {
                            list.RemoveAt(i + 1);
                            temp++;
                        }
                    }
                }
            }

            Console.WriteLine("За все итерации преобразовано двойных пробелов = {0} \n\nУУдалим двойные пробелы и получим " +
                "следующий результат:", temp);

            foreach(char c in list)
            {
                Console.Write(c);
            }

            Console.ReadKey();


        }
    }
}
