

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RomanovMV.Sprint4.V9.Task0.Lib
{
    public class DataService : ISprint4Task0V9
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum = sum + array[i];
                }
            }
            return sum;
        }
    }
}

