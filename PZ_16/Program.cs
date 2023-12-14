namespace PZ_16
{
    internal class Program
    {
        static char[,] map = new char[25, 25];
        static int playerX, playerY;
        static int playerHP = 50;
        static int playerDamage = 10;
        static int steps = 0;
        static int enemyCount = 10;

        static int[] enemyX = new int[10];
        static int[] enemyY = new int[10];
        static int[] enemyHP = new int[10];
        static int[] enemyDamage = new int[10];

        static int[] itemX = new int[10];
        static int[] itemY = new int[10];
        static char[] itemType = new char[10];

        static bool gameRunning = true;

        static void Main(string[] args)
        {
            Prewie();
        }

        static void Prewie()
        {

            Console.Clear();
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("N - начать новую игру");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("Z - загрузить последнее сохранение");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.N:
                    InitializeMap();
                    InitializePlayer();
                    InitializeEnemies();
                    InitializeItems();

                    while (gameRunning)
                    {
                        Console.Clear();
                        DrawMap();

                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        HandlePlayerMovement(keyInfo);

                        if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            GameOver();
                        }

                        steps++;
                    }
                    break;
                case ConsoleKey.Z:
                    Console.Clear();
                    Console.SetCursorPosition(40, 15);
                    LoadGame();
                    while (gameRunning)
                    {
                        Console.Clear();
                        DrawMap();

                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        HandlePlayerMovement(keyInfo);

                        if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            GameOver();
                        }

                        steps++;
                    }
                    break;
                default: //если игрок нажимает на другие клавиши то стартовый экран не пропадает
                    Prewie();
                    break;
            }
        }

        static void InitializeMap()
        {
            Console.Clear();
            // Генерация карты
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    map[i, j] = '_';
                }
            }
        }

        static void InitializePlayer()
        {
            // Помещение игрока в середину карты
            playerX = 12;
            playerY = 12;
            map[playerY, playerX] = 'P';
        }

        static void InitializeEnemies()
        {
            Random random = new Random();

            // Генерация врагов
            for (int i = 0; i < 10; i++)
            {
                int x, y;
                do
                {
                    x = random.Next(0, 25);
                    y = random.Next(0, 25);
                } while (map[y, x] != '_');

                enemyX[i] = x;
                enemyY[i] = y;
                enemyHP[i] = 30;
                enemyDamage[i] = 5;
                map[y, x] = 'E';
            }
        }

        static void InitializeItems()
        {
            Random random = new Random();

            // Генерация аптечек и баффов
            for (int i = 0; i < 10; i++)
            {
                int x, y;
                do
                {
                    x = random.Next(0, 25);
                    y = random.Next(0, 25);
                } while (map[y, x] != '_');

                itemX[i] = x;
                itemY[i] = y;

                if (i < 5)
                {
                    itemType[i] = 'H'; // Аптечка
                    map[y, x] = 'H';
                }
                else
                {
                    itemType[i] = 'B'; // Бафф
                    map[y, x] = 'B';
                }
            }
        }

        static void DrawMap()
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    switch (map[i, j])
                    {
                        case 'P':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 'E':
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 'H':
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 'B':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        default:
                            Console.ResetColor();
                            break;
                    }
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Здоровье игрока: " + playerHP);
            Console.WriteLine("Сила игрока: " + playerDamage);
            Console.WriteLine("Шаги: " + steps);
        }

        static void HandlePlayerMovement(ConsoleKeyInfo keyInfo)
        {
            // Перемещение игрока
            int newX = playerX, newY = playerY;

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    newY--;
                    break;
                case ConsoleKey.DownArrow:
                    newY++;
                    break;
                case ConsoleKey.LeftArrow:
                    newX--;
                    break;
                case ConsoleKey.RightArrow:
                    newX++;
                    break;
            }

            // Проверка на возможность перемещения
            if (newX >= 0 && newX < 25 && newY >= 0 && newY < 25)
            {
                if (map[newY, newX] == '_')
                {
                    map[playerY, playerX] = '_';
                    playerX = newX;
                    playerY = newY;
                    map[playerY, playerX] = 'P';
                }
                else if (map[newY, newX] == 'H')
                {
                    map[playerY, playerX] = '_';
                    playerX = newX;
                    playerY = newY;
                    map[playerY, playerX] = 'P';
                    playerHP = 50;
                }
                else if (map[newY, newX] == 'B')
                {
                    map[playerY, playerX] = '_';
                    playerX = newX;
                    playerY = newY;
                    map[playerY, playerX] = 'P';
                    playerDamage *= 2;
                }
                else if (map[newY, newX] == 'E')
                {
                    map[playerY, playerX] = '_';
                    playerX = newX;
                    playerY = newY;
                    map[playerY, playerX] = 'P';
                    if (playerDamage == 10)
                    {
                        playerHP -= 15;
                        enemyCount--;
                    }
                    else if (playerDamage == 20)
                    {
                        playerHP -= 10;
                        enemyCount--;
                    }
                    else if (playerDamage >= 40)
                    {
                        playerHP -= 5;
                        enemyCount--;
                    }
                    if (enemyCount == 0)
                    {
                        GameOverWin();
                    }
                    if (playerHP <= 0)
                    {
                        GameOverLose();
                    }
                }
            }
        }

        static void GameOver()
        {
            gameRunning = false;
            Console.Clear();
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("Игра окончена!");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("Шагов сделано: " + steps);

            // Сохранение состояния игры
            Console.SetCursorPosition(40, 17);
            Console.WriteLine("Вы хотите сохранить игру? (Y/N)");
            string choice = Console.ReadLine();

            if (choice.ToUpper() == "Y")
            {
                SaveGame();
            }
        }
        static void GameOverWin()
        {
            gameRunning = false;
            Console.Clear();
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("Игра окончена! Победа!!!");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("Шагов сделано: " + steps);
        }

        static void GameOverLose()
        {
            gameRunning = false;
            Console.Clear();
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("Игра окончена! Поражение:(");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("Шагов сделано: " + steps);
        }

        static void SaveGame()
        {
            // Создание или перезапись файла save.txt
            using (StreamWriter writer = new StreamWriter("save.txt"))
            {

                writer.WriteLine(playerX);
                writer.WriteLine(playerY);
                writer.WriteLine(playerHP);
                writer.WriteLine(playerDamage);
                writer.WriteLine(steps);

                // Сохранение карты в файл
                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        writer.Write(map[i, j]);
                    }
                    writer.WriteLine();

                }
            }
        }

        static void LoadGame()
        {
            using (StreamReader reader = new StreamReader("save.txt"))
            {
                playerX = int.Parse(reader.ReadLine());
                playerY = int.Parse(reader.ReadLine());
                playerHP = int.Parse(reader.ReadLine());
                playerDamage = int.Parse(reader.ReadLine());
                steps = int.Parse(reader.ReadLine());
                for (int i = 0; i < 25; i++)
                {
                    string save = reader.ReadLine();
                    for (int j = 0; j < 25; j++)
                    {
                        map[i, j] = save[j];
                    }
                }
            }
        }
    }
}