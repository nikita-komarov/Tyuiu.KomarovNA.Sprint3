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
            for (int i = startValue; i<=stopValue; i++)
            {
                sum += (Math.Pow(t, 2 * i) + 1 / (i+1)) * Math.Cos(t);
            }
            return sum;
        }
    }
}
