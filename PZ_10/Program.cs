using System.Text.RegularExpressions;

namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод текста с консоли
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();

            // Перевод времени в формат GMT+5
            string outputText = ConvertTimeToGMT5(inputText);

            // Вывод результата
            Console.WriteLine("Текст с переведенным временем:");
            Console.WriteLine(outputText);
        }

        static string ConvertTimeToGMT5(string inputText)
        {
            // Регулярное выражение для поиска времени в формате HH.MM.SS
            string pattern = @"\b([0-9]{2})\.([0-9]{2})\.([0-9]{2})\b";

            // Замена времени на GMT+5
            string outputText = Regex.Replace(inputText, pattern, match =>
            {
                int hours = int.Parse(match.Groups[1].Value);
                int minutes = int.Parse(match.Groups[2].Value);
                int seconds = int.Parse(match.Groups[3].Value);

                // Перевод времени на GMT+5
                hours += 5;
                if (hours >= 24)
                {
                    hours -= 24;
                }

                // Форматирование времени в формат HH.MM.SS
                string time = hours.ToString("D2") + "." + minutes.ToString("D2") + "." + seconds.ToString("D2");

                return time;
            });

            return outputText;
        }
    }
}