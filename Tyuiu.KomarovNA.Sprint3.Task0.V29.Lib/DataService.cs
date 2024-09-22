using System.Runtime.Intrinsics.Arm;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KomarovNA.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            double t = value;
            for (int k = startValue; k<=stopValue; k++)
            {
                sum += (Math.Pow(t, 2 * k) + (1.0 / (k+1))) * Math.Cos(t);
            }
            return Math.Round(sum, 3);
        }
    }
}
