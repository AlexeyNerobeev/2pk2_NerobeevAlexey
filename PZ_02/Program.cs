using System;
namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения чисел p (любое целое число) и q (не равно нулю):"); //вводим значения переменных p и q
            int p = Int32.Parse(Console.ReadLine());
            double q = Double.Parse(Console.ReadLine());
            double n, m, k; //добавляем переменные, значения которых надо будет вычислить
            if (p > 2) //находим значение n
            {
                n = (Math.Pow(Math.Sin(p + q), 3)) + (Math.Sqrt(Math.Abs(p) + 1));
            }
            else 
            {
                n = p * Math.Cos(q) + 1 / Math.Sqrt(Math.Abs(q));
            }
            if (n <= 2) //находим значение m
            {
                m = Math.Pow(Math.E, 2 * p) + Math.Log(p * n);
            }
            else 
            {
                m = 13 * n; 
            }
            k = 2 + 13 * n - ((p * m + q * n) / (2.5)); //находим значение k
            Console.WriteLine("p =" + p); //выводим все числа
            Console.WriteLine("q =" + q);
            Console.WriteLine("n =" + n);
            Console.WriteLine("m =" + m);
            Console.WriteLine("k =" + k);
            Console.ReadKey();
        }
    }
}