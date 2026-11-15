

using Tyuiu.RomanovMV.Sprint4.Task4.V14.Lib;


namespace Tyuiu.RomanovMV.Sprint4.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int rows;
            Console.WriteLine("Введите количество строк массива");
            rows = Convert.ToInt32(Console.ReadLine());

            int columns;
            Console.WriteLine("Введите количество столбцов массива");
            columns = Convert.ToInt32(Console.ReadLine());

            int[,] mat = new int[rows, columns];

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {i}{j} элемент массива:");
                    mat[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("");
            }



            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mat[i,j]} \t");
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
