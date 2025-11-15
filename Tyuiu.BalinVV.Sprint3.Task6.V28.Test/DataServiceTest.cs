using Tyuiu.BalinVV.Sprint3.Task6.V28.Lib;
namespace Tyuiu.BalinVV.Sprint3.Task6.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 13;
            int stopValue = 19;

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 15; 

            Assert.AreEqual(wait, result);
        }
    }
}
