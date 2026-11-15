

using Tyuiu.RomanovMV.Sprint4.Task5.V28.Lib;



namespace Tyuiu.RomanovMV.Sprint4.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mat = {  { -1, 2 }, { 3, 4 },
                            { 5, -6 }, { -7, -8 } };
            int[,] res = ds.Calculate(mat);
            int[,] wait = {  { 0, 2 }, { 3, 4 },
                            { 5, 0 }, { 0, 0 } };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
