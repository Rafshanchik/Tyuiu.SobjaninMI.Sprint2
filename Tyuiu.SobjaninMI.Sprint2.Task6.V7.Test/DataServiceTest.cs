using Tyuiu.SobjaninMI.Sprint2.Task6.V7.Lib;

namespace Tyuiu.SobjaninMI.Sprint2.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Январь", ds.FindMonthName(1990, 0));
            Assert.AreEqual("Февраль", ds.FindMonthName(1990, 1));
            Assert.AreEqual("Декабрь", ds.FindMonthName(1990, 11));
            Assert.AreEqual("Январь", ds.FindMonthName(1990, 12));
            Assert.AreEqual("Февраль", ds.FindMonthName(1990, 25));
        }
    }
}