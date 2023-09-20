namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //первое задание
                Console.WriteLine("Первое задание:");
                for (int y = 10; y <= 90; y += 3)
                {
                    Console.WriteLine(y);
                }
                //второе задание
                Console.WriteLine("Второе задание:");
                for (char a = 'Б'; a <= 'Ж'; a++)
                {
                    Console.WriteLine(a);
                }
                //третье задание
                Console.WriteLine("Третье задание:");
                string b = "#####";
                for (int c = 0; c < 7; c++)
                {
                    Console.WriteLine(b);
                }
                //четвертое задание
                Console.WriteLine("Четвертое задание");
                int count = 0;

                for (int d = -50; d <= 50; d++)
                {
                    if (d % 8 == 0)
                    {
                        Console.Write(d + " ");
                        count++;
                    }
                }

                Console.WriteLine("\nКоличество чисел, кратных 8: " + count);
                //пятое задание
                Console.WriteLine("Пятое задание");
                for (int i = 3, j = 60; j - i >= 13; i++, j--)
                {
                    Console.WriteLine(j - i);
                }
        }
    }
}
    
