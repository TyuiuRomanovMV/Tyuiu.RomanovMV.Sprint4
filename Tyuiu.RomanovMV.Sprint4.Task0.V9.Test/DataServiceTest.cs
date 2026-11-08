
using Tyuiu.RomanovMV.Sprint4.V9.Task0.Lib;

namespace Tyuiu.RomanovMV.Sprint4.V9.Task0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] numArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int res = ds.GetSumEvenArrEl(numArray);
            int wait = 38;
            Assert.AreEqual(res, wait);
        }
    }
}
