

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RomanovMV.Sprint4.V9.Task0.Lib
{
    public class DataService : ISprint4Task0V9
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = array[0] + array[1] + array[2] + array[3];
            return sum;
        }
    }
}

