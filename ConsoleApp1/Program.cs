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
            int[] Array = new int[] { -7, 1, 5, 2, -4, 3, 0 };
            int leftSum;
            int rightSum;
            int temp = 0;
            bool trust = true;
            
            do
            {
                for (int k = 1; k < Array.Length; k++)
                {
                    leftSum = 0;
                    rightSum = 0;
                    temp++;
                    for (int i = 0; i < k; i++)
                    {
                        leftSum += Array[i];
                    }
                        for (int j = Array.Length - 1; j > k; j--)
                    {
                        rightSum += Array[j];
                    }
                    if (leftSum == rightSum)
                    {
                        trust = false;
                        break;
                    }
                }
            } while (trust == true) ;

            Console.WriteLine("Элемент массива с равнозначной суммой левой и праввой частей массива = {0}", temp);
            Console.ReadKey();
        } 
    }
}
