

using Tyuiu.RomanovMV.Sprint4.V9.Task0.Lib;

namespace Tyuiu.RomanovMV.Sprint4.V9.Task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            for (int i = 0; i <= numArray.Length - 1; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            int sum = ds.GetSumEvenArrEl(numArray);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма всех чётных элементов элементов = " + sum);

            Console.ReadKey();
        }
    }
}
