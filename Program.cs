using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2. Даны положительные числа A и B (A > B). На отрезке длины A 
    размещено максимально возможное количество отрезков длины B 
    (без наложений). Не используя операции умножения и деления, 
    найти количество отрезков B, размещенных на отрезке A.
*/
namespace Lab_3_1_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 12;
            int B = 3;

            int count = 0;
            while (A >= B)
            {
                A = A - B;
                count++;
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
