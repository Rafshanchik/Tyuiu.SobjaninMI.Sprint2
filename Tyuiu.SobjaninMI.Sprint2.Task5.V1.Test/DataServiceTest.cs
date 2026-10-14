using Tyuiu.SobjaninMI.Sprint2.Task5.V1.Lib;
namespace Tyuiu.SobjaninMI.Sprint2.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthDaysCount()
        {
            DataService ds = new DataService();
            int month = 1;
            int wait = 31;
            int res = ds.FindMonthDaysCount(month);
            Assert.AreEqual(wait, res);
        }
    }
}
