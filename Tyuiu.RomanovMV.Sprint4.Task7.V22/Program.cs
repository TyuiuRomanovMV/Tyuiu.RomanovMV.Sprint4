

using Tyuiu.RomanovMV.Sprint4.Task7.V22.Lib;


// "695324951753684"

namespace Tyuiu.RomanovMV.Sprint4.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Исходная строка: 695324951753684");
            int n = 5; int m = 3; string value = "695324951753684";

            Console.WriteLine("Колличество строк массива = " + n);
            Console.WriteLine("Колличество столбцов массива = " + m);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("\n Массив:");

            int index = 0;
            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(n, m, value);
            Console.WriteLine($"Произведение чётных элементов массива = {res}");
            

            Console.ReadKey();
        }
    }
} 