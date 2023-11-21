namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица значений функции y = f(x):");
            Console.WriteLine("x\t|\ty");
            int x = -2;
            double t = 3.14; // Произвольное значение для t
            while (x <= 12)
            {
                double y;
                if (x < 0)
                {
                    y = t;
                }
                else if (x < 10)
                {
                    y = t * x;
                }
                else
                {
                    y = 2 * t;
                }
                Console.WriteLine($"{x}\t|\t{y}");
                x += 2;
            }
            Console.WriteLine();
            x = -2;
            do
            {
                double y;
                if (x < 0)
                {
                    y = t;
                }
                else if (x < 10)
                {
                    y = t * x;
                }
                else
                {
                    y = 2 * t;
                }
                Console.WriteLine($"{x}\t|\t{y}");
                x += 2;
            } while (x <= 12);
        }
    }
}