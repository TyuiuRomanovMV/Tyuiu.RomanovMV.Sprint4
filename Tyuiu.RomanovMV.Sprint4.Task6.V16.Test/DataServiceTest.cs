

using Tyuiu.RomanovMV.Sprint4.Task6.V16.Lib;


namespace Tyuiu.RomanovMV.Sprint4.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] line = ["Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро"];
            string[] res = ds.Calculate(line);
            string[] wait = ["Самолет", "Трамвай"];
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
