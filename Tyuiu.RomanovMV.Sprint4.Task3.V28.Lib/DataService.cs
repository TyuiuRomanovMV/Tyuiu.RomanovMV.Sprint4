

using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.RomanovMV.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int num1 = 10;
            int rows = array.GetUpperBound(0) + 1; int columns = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 3)
                    {
                        if (array[i, j] < num1)
                        {
                            num1 = array[i, j];
                        }
                    }
                }
            }
            return num1;
        }
    }
}
