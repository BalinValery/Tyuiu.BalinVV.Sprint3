using Tyuiu.BalinVV.Sprint3.Task0.V11.Lib;
namespace Tyuiu.BalinVV.Sprint3.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValueGetSumSeries()
        {
         DataService ds = new DataService();

            double value = 5;
            int StartValue = 1;
            int StopValue = 10;
            double res = ds.GetSumSeries((int)value, StartValue, StopValue);
            double wait = 0.016;
            Assert.AreEqual(wait, res);


        }
        
    }
}
