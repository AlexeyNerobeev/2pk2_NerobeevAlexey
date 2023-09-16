namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 365:"); //пользователь вводит число от 1 до 365, чтобы определить какой это день недели
            int i = Convert.ToInt32(Console.ReadLine());
            int day = i % 7; //вычисляем остаток от числа i
            switch (day) //по остатку определяем день недели
            {
                case 0:
                    Console.WriteLine("Воскресенье");
                    break;
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    break;
                    Console.WriteLine("Воскресенье");
                    break;
                default: //если число введено не в диапазоне от 1 до 365 или не целое число, то выводим на консоль: "Ошибка ввода"
                    Console.WriteLine("Ошибка ввода");
                    break;
            }
            Console.ReadKey(); //конец программы
        }
    }
}