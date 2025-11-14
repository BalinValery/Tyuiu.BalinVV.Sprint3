using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BalinVV.Sprint3.Task0.V11.Lib
{
    public class DataService : ISprint3Task0V11
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries += 1.0 / Math.Pow(value, 4); 
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
