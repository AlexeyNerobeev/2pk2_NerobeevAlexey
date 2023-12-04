namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный путь к каталогу:");
            string directoryPath = Console.ReadLine();

            // Проверка наличия каталога
            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("Каталог не существует.");
                return;
            }

            // Получение списка файлов в каталоге
            string[] files = Directory.GetFiles(directoryPath, "*.txt");

            // Проверка наличия файлов
            if (files.Length == 0)
            {
                Console.WriteLine("В указанном каталоге нет текстовых файлов.");
                return;
            }

            foreach (string filePath in files)
            {
                try
                {
                    // Открытие файла для дозаписи
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        // Получение и форматирование времени создания файла
                        DateTime creationTime = File.GetCreationTime(filePath);
                        string formattedTime = creationTime.ToString("dd.MM.yyyy HH:mm:ss");

                        // Дозапись времени создания в файл
                        writer.WriteLine($"Время создания файла: {formattedTime}");
                    }

                    Console.WriteLine($"Файл {Path.GetFileName(filePath)} обновлен.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при обновлении файла {Path.GetFileName(filePath)}: {ex.Message}");
                }
            }
        }
    }
}