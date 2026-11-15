


using tyuiu.cources.programming.interfaces.Sprint4;



namespace Tyuiu.RomanovMV.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            int index = 0;
            int[,] mat = new int[n, m];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(value.Substring(index, 1));
                    index++;
                }
            }

            int res = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i, j] % 2 ==0)
                    {
                        res *= mat[i, j];
                    }
                }
            }
            return res;
        }
    }
}
