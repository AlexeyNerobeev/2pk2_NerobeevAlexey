namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Исходные данные
            int rows = 5;
            int minCols = 6;
            int maxCols = 15;

            // 1. Создание ступенчатого массива
            char[][] jaggedArray = GenerateJaggedArray(rows, minCols, maxCols);

            Console.WriteLine("Исходный массив:");
            PrintJaggedArray(jaggedArray); // 2. Вывод исходного массива

            char[] lastElements = GetLastElements(jaggedArray); // 3. Получение последних элементов каждой строки
            Console.WriteLine("\nМассив последних элементов:");
            Console.WriteLine(lastElements); // Вывод массива последних элементов

            char[] maxElements = GetMaxElements(jaggedArray); // 4. Получение максимальных элементов каждой строки
            Console.WriteLine("\nМассив максимальных элементов:");
            Console.WriteLine(maxElements); // Вывод массива максимальных элементов

            SwapFirstAndMax(jaggedArray); // 5. Меняем местами первый элемент и максимальный в каждой строке
            Console.WriteLine("\nОбновленный массив:");
            PrintJaggedArray(jaggedArray); // Вывод обновленного массива

            ReverseStrings(jaggedArray); // 6. Реверс каждой строки массива
            Console.WriteLine("\nМассив после реверса:");
            PrintJaggedArray(jaggedArray); // Вывод массива после реверса

            char[] mostFrequentCharacters = GetMostFrequentCharacters(jaggedArray); // 7. Наиболее встречающиеся символы в каждой строке
            Console.WriteLine("\nНаиболее встречающиеся символы в каждой строке:");
            Console.WriteLine(mostFrequentCharacters); // Вывод наиболее встречающихся символов в каждой строке

            Console.ReadLine();
        }

        static char[][] GenerateJaggedArray(int rows, int minCols, int maxCols)
        {
            Random random = new Random();

            char[][] jaggedArray = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                int cols = random.Next(minCols, maxCols + 1);
                jaggedArray[i] = new char[cols];

                for (int j = 0; j < cols; j++)
                {
                    jaggedArray[i][j] = (char)random.Next('A', 'Z' + 1); // Заполнение массива случайными символами от 'A' до 'Z'
                }
            }

            return jaggedArray;
        }

        static void PrintJaggedArray(char[][] jaggedArray)
        {
            foreach (char[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        static char[] GetLastElements(char[][] jaggedArray)
        {
            char[] lastElements = new char[jaggedArray.Length];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                lastElements[i] = jaggedArray[i][jaggedArray[i].Length - 1];
            }

            return lastElements;
        }

        static char[] GetMaxElements(char[][] jaggedArray)
        {
            char[] maxElements = new char[jaggedArray.Length];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                maxElements[i] = jaggedArray[i].Max();
            }

            return maxElements;
        }

        static void SwapFirstAndMax(char[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                char firstElement = jaggedArray[i][0];
                char maxElement = jaggedArray[i].Max();
                int maxIndex = Array.IndexOf(jaggedArray[i], maxElement);

                jaggedArray[i][0] = maxElement;
                jaggedArray[i][maxIndex] = firstElement;
            }
        }

        static void ReverseStrings(char[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Array.Reverse(jaggedArray[i]);
            }
        }

        static char[] GetMostFrequentCharacters(char[][] jaggedArray)
        {
            char[] mostFrequentCharacters = new char[jaggedArray.Length];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                // Создаем словарь для подсчета количества встреч символов
                Dictionary<char, int> charCounts = new Dictionary<char, int>();

                // Подсчитываем количество встреч каждого символа в текущей строке
                foreach (char c in jaggedArray[i])
                {
                    if (charCounts.ContainsKey(c))
                    {
                        charCounts[c]++;
                    }
                    else
                    {
                        charCounts[c] = 1;
                    }
                }

                // Находим символ с максимальным количеством встреч
                char mostFrequentChar = charCounts.OrderByDescending(x => x.Value).First().Key;

                mostFrequentCharacters[i] = mostFrequentChar;
            }

            return mostFrequentCharacters;
        }
    }
}