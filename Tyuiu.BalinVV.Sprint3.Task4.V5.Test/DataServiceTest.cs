using Tyuiu.BalinVV.Sprint3.Task4.V5.Lib;
namespace Tyuiu.BalinVV.Sprint3.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5, end = 5;
            double res = ds.Calculate(start, end);
            Assert.AreEqual(-0.858, res);
        }
    }
}
