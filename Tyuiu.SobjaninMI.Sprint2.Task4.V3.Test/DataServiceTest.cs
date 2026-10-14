using Tyuiu.SobjaninMI.Sprint2.Task4.V3.Lib;
namespace Tyuiu.SobjaninMI.Sprint2.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(2.333, res );
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(2.5, res);
        }
    }
}
