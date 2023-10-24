//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

using System;

namespace FromMtoN_Sum
{
    public static class Program
    {
        public static int SumNumbers1(int m, int n) // n > m
        {
            if (n == m)
            {
                return m;
            }
            else
            {
                return n + SumNumbers1(m, n - 1);
            }
        }

        public static int SumNumbers2(int m, int n) // m > n
        {
            if (n == m)
            {
                return n;
            }
            else
            {
                return m + SumNumbers1(n, m - 1);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Введите число М");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());

            if (m < n)
            {
                Console.WriteLine(SumNumbers1(m, n));
            }
            else if (m > n)
            {
                Console.WriteLine(SumNumbers2(m, n));
            }
            else
            {
                Console.WriteLine(m);
            }
        }
    }
}
