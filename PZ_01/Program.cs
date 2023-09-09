using System;
namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводим значения переменных
            Console.WriteLine("Введите значение переменной a:");
            string aIn = Console.ReadLine();
            Console.WriteLine("Введите значение переменной b:");
            string bIn = Console.ReadLine();
            Console.WriteLine("Введите значение переменной c:");
            string cIn = Console.ReadLine();
            //Создаем переменные для изменения их значений
            double a;
            double b;
            double c;
            //Проверяем содержание переменной a
            if (aIn.ToLower() == "пи/2") { a = Math.PI; }
            else { a = double.Parse(aIn); }
            //Проверяем содержание переменной b
            if (bIn.ToLower() == "пи/2") { b = Math.PI; }
            else { b = double.Parse(bIn); }
            //Проверяем содержание переменной c
            if (cIn.ToLower() == "пи/2") { c = Math.PI; }
            else { c = double.Parse(cIn); }
            //Возмодим 10 в четвертую степень
            double result1 = Math.Pow(10, 4);
            //Вычисляем модуль косинуса b
            double result2 = Math.Abs(Math.Cos(b));
            //умножаем result1 на корень пятой степени result2
            double result3 = result1 * Math.Pow(result2, 1 / 5);
            //Вычитаем из квадратного корня (abc)/2.4 дробь (0.7*abc)/sin b 
            double result4 = (Math.Sqrt((a * b * c) / 2.4)) - ((0.7 * a * b * c) / (Math.Sin(b)));
            //Складываем result4 и result3 
            double result5 = result4 + result3;
            //Вычитаем из result5 дробь (|b-a|)/7.5
            double result6 = result5 - ((Math.Abs(b - a)) / 7.5);
            //Выводим ответ на консоль
            Console.WriteLine("Результат:" + result6);
            Console.ReadKey();
        }
    }
}