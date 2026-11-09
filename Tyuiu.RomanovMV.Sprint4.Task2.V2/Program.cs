

using Tyuiu.RomanovMV.Sprint4.Task2.V2.Lib;


namespace Tyuiu.RomanovMV.Sprint4.Task2.V2
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
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int len;
            Console.WriteLine("Введите длину массива");
            len = Convert.ToInt32(Console.ReadLine());

            
            int[] array = new int[len];



            Console.WriteLine("Элементы массива:");
            for (int i = 0; i <= len - 1; i++)
            {
                array[i] = rnd.Next(1, 8);
                Console.Write(array[i] + "\t");
            }

            int res = ds.Calculate(array);


            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение всех нечётных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}
