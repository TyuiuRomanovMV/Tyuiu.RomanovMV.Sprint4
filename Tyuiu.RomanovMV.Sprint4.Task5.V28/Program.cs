


using Tyuiu.RomanovMV.Sprint4.Task5.V28.Lib;


namespace Tyuiu.RomanovMV.Sprint4.Task5.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5; int columns = 5;

            int[,] mat = new int[rows, columns];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mat[i, j] = rnd.Next(-6, 3);
                }
                Console.WriteLine("");
            }



            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mat[i, j]} \t");
                }
                Console.WriteLine("");
            }

            int[,] res = ds.Calculate(mat);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{res[i, j]} \t");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
