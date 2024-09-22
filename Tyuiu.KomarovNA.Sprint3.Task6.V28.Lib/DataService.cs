﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KomarovNA.Sprint3.Task6.V28.Lib
{
    public class DataService : ISprint3Task6V28
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    if (j%i == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
