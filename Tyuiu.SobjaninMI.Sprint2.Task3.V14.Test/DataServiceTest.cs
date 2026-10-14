using Tyuiu.SobjaninMI.Sprint2.Task3.V14.Lib;
namespace Tyuiu.SobjaninMI.Sprint2.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            Assert.AreEqual(-25.0, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.75, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1.0;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.5, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -20.0;
            double res = ds.Calculate(x);
            Assert.AreEqual(-219.95, res);
        }
    }
}
