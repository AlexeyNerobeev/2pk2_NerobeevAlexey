namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод строки с консоли
            Console.WriteLine("Введите строку:");
            string inputStr = Console.ReadLine();

            // Нахождение самого маленького слова
            string smallestWord = GetSmallestWord(inputStr);

            // Перенос самого маленького слова в начало строки
            string outputStr = MoveSmallestWordToBeginning(inputStr, smallestWord);

            // Вывод результата
            Console.WriteLine("Преобразованная строка:");
            Console.WriteLine(outputStr);
        }

        static string GetSmallestWord(string inputStr)
        {
            string[] words = inputStr.Split(' ');

            string smallestWord = words[0];
            foreach (string word in words)
            {
                if (word.Length < smallestWord.Length)
                {
                    smallestWord = word;
                }
            }

            return smallestWord;
        }

        static string MoveSmallestWordToBeginning(string inputStr, string smallestWord)
        {
            string outputStr = inputStr.Replace(smallestWord, "");
            outputStr = smallestWord + " " + outputStr.Trim();

            return outputStr;
        }

    }
}
