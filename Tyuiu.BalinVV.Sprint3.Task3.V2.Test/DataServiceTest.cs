using Tyuiu.BalinVV.Sprint3.Task3.V2.Lib;
namespace Tyuiu.BalinVV.Sprint3.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();

            string str = " asdzzz vfvfzz v gthvz";
            char chr = 'z';
            double res = ds.GetMaxCharCount(str, chr);
            int wait = 3;
            Assert.AreEqual(res, wait);
        }
    }
}
