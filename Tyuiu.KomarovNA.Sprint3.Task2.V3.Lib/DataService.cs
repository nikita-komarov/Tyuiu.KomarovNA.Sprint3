using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KomarovNA.Sprint3.Task2.V3.Lib
{
    public class DataService : ISprint3Task2V3
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int x = value;
            int i = startValue;

            do
            {
                sum = (Math.Pow(x, 2) * i) + 1;
                i++;
            } while (i < stopValue);

            return Math.Round(sum, 3);
        }
    }
}
