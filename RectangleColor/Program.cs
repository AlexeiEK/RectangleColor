using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ввод высоты прямоугольника: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ввод ширины прямоугольника: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ввод символа прямоугольника: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            var flag = 0;
            do
            {
                Console.Write("Ввод цвета символа прямоугольника: ");
                var color = Console.ReadLine();
                color = color.ToUpper();
                flag = 1;
                switch (color)
                {
                    case "КРАСНЫЙ":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "ЖЁЛТЫЙ":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "СИНИЙ":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "ЗЕЛЁНЫЙ":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "БЕЛЫЙ":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("Выберите другой цвет.");
                        flag = 0;
                        break;
                }
            } while (flag == 0);

            Console.WriteLine();
            Console.WriteLine("    Прямоугольник");
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                Console.Write("\t");
                if (i == 0 || i == height - 1)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(symbol);
                    }
                }
                else
                {
                    Console.Write(symbol);
                    for (int j = 1; j < width - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}