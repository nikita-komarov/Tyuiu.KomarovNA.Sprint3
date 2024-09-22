using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KomarovNA.Sprint3.Task7.V17.Lib
{
    public class DataService : ISprint3Task7V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[15];
            int index = 0;
            for (int i = startValue; i<=stopValue; i++)
            {

                int x = i;
                double y;
                if (x+1.7==0)
                {
                    y = 0;
                } else
                {
                    y = (Math.Sin(x)) / (x+1.7) - Math.Cos(x) * 4*x - 6;
                }
                result[index] = (Math.Round(y, 2));
                index++;
            }
            return result;
        }
    }
}
