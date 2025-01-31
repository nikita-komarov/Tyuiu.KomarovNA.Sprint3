﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KomarovNA.Sprint3.Task3.V23.Lib
{
    public class DataService : ISprint3Task3V23
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    value = value.Replace(c, replacement);
                }
            }
            return value;
        }
    }
}
