using System;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandOne = "1";
            const string CommandTwo = "2";
            const string CommandThree = "3";
            const string CommandFour = "4";

            string userInput;
            string setName = "";
            int setPassword;
            int minNumber = 1;
            int maxNumber = 5;
            int darkYellow = 1, darkGreen = 2, darkCyan = 3, darkMagenta = 4;
            bool isRepeat = true;

            Random random = new Random();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            while (isRepeat)
            {
                Console.WriteLine("Menu\n");
                Console.WriteLine($"{CommandOne}: Ввести имя\n{CommandTwo}: ChangeConsoleColor\n{CommandThree}: Установить пароль\n{CommandFour}: Выход "); ;
                userInput = Console.ReadLine();

                Console.Clear();

                switch (userInput)
                {
                    case CommandOne:
                        Console.WriteLine("Введите ваше имя");
                        setName = Console.ReadLine();

                        Console.Clear();
                        break;

                    case CommandTwo:
                        int changeConsoleColor = random.Next(minNumber, maxNumber);

                        if (changeConsoleColor == darkYellow)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Clear();
                        }
                        else if (changeConsoleColor == darkGreen)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Clear();
                        }
                        else if (changeConsoleColor == darkCyan)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.Clear();
                        }
                        else if (changeConsoleColor == darkMagenta)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.Clear();
                        }

                        break;

                    case CommandThree:
                        Console.WriteLine("Установите пароль");
                        setPassword = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("Введите пароль");
                        int password = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                        if (password == setPassword)
                        {
                            Console.WriteLine(setName);
                            Console.WriteLine("\nEnter");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case CommandFour:
                        isRepeat = false;
                        break;
                }
            }
        }
    }
}
