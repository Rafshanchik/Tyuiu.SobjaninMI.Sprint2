using Tyuiu.SobjaninMI.Sprint2.Task7.V4.Lib;
namespace Tyuiu.SobjaninMI.Sprint2.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea1()
        {
            DataService ds = new DataService();
            double x = 0.2;
            double y = 0.1;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();
            double x = 0.8;
            double y = 0.7;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea3()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, result);
        }
    }
}
