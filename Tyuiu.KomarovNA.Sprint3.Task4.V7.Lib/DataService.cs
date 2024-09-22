using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KomarovNA.Sprint3.Task4.V7.Lib
{
    public class DataService : ISprint3Task4V7
    {
        public double Calculate(int startValue, int stopValue)
        {
            double accumulator = 1;
            int x = startValue;
            while (true)
            {
                if (x==0)
                {
                    break;
                }
                accumulator *= x/Math.Cos(x) + 1.5;
                x++;
            }
            return Math.Round(accumulator, 3);
        }
    }
}
