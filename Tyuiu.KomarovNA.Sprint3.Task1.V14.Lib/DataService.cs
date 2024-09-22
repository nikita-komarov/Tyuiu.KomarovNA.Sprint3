using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KomarovNA.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            double t = value;
            int k = 1;
            while (k<=14)
            {
                sum += (Math.Pow(t, k) + (1/(k+1))) * Math.Cos(t);
                k++;
            }
            return Math.Round(sum, 3);
        }
    }
    }
}
