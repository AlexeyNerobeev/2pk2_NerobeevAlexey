namespace PZ_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание:");
            Console.WriteLine(Arifm(5, 7, -0.1));
            Console.WriteLine("Второе задание:");
            Console.WriteLine(Geom(5, 13, -2));
            Console.WriteLine("Третье задание:");
            Console.WriteLine(Numbers(8, 65));
            Console.WriteLine("Четвертое задание:");
            Console.WriteLine(Summ(5));
        }
        static double Arifm(double n, double a, double d) // №1
        {
            double result = 0;
            if (n != 0)
            {
                result = a + d * (n - 1);
                Arifm(n - 1, a, result);
            }
            return result;
        }
        static double Geom(double n, double b, double q) // №2
        {
            double result = 1;
            if (n != 0)
            {
                result = b * Math.Pow(q, n - 1);
                Geom(n - 1, b, result);
            }
            return result;
        }
        static int Numbers(int a, int b)// №3
        {
            if (a != b)
            {
                Console.Write($"{a} ");
                Numbers(a + 1, b);
            }
            return b;
        }
        static int Summ(int x)
        {
            int result = 0;
            if (x > 0)
            {
                result = x + Summ(x - 1);
            }
            return result;
        }
    }
}