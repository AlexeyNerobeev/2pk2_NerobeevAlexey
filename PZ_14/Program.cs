namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\ПЗ\ПЗ14.txt"; // Путь к файлу с текстом
            // Чтение текста из файла
            string[] lines = File.ReadAllLines(filePath);
            int lineCount = lines.Length;
            int wordCount = 0;
            int charCount = 0;
            // Подсчет количества слов и символов в каждой строке
            foreach (string line in lines)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                wordCount += words.Length;
                charCount += line.Length;
            }
            double averageCharsPerLine = (double)charCount / lineCount;
            // Дозапись данных в конец файла
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"Количество строк: {lineCount}");
                writer.WriteLine($"Количество слов: {wordCount}");
                writer.WriteLine($"Среднее количество символов в строках: {averageCharsPerLine}");
            }
            Console.WriteLine("Данные успешно записаны в файл.");
        }
    }
}