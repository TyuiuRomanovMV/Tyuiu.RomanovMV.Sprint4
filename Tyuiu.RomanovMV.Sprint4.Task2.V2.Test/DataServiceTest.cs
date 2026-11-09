

using Tyuiu.RomanovMV.Sprint4.Task2.V2.Lib;


namespace Tyuiu.RomanovMV.Sprint4.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, };
            int res = ds.Calculate(array);
            int wait = 25725;
            Assert.AreEqual(wait, res);
        }
    }
}
