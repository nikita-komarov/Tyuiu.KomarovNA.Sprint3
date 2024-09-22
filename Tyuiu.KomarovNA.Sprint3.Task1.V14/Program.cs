using Tyuiu.KomarovNA.Sprint3.Task1.V14.Lib;
namespace Tyuiu.KomarovNA.Sprint3.Task1.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор if - полная и короткая форма записи                            *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу на, которая запрашивает целые значения с клавиатуры и *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
            Console.WriteLine("*и.                                                                       *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();


            //int a = 6;
            //int b = 4;
            //int c = 8;
            //int d = 7;
            //int i = 1;
            //do
            //{
            //    b++;
            //    b = a+c;
            //    c = b-a;
            //    d = (a-c) - i;
            //    i++;
            //} while (i < 4);
            //Console.WriteLine(d);

            //string str = "cdfgcc cfgc ctf";
            //foreach (char c in str)
            //{
            //    if (c == 'c')
            //    {
            //        str = str.Replace(c, 'w');
            //    }
            //}
            //Console.WriteLine(str);

            //int x;
            //double sp = 1;
            //int i = 0;
            //for (x = -2; x <= 2; x++) 
            //{
            //    if (x == 0) 
            //    {
            //        continue;
            //    }
            //    sp = sp * (2*x+2);
            //    i++;
            //}
            //Console.WriteLine(sp);

            //double s0 = 0;
            //double s1 = 0;
            //int x = 2;
            //for (int j = 1; j<= 3; j++)
            //{
            //    for (int k = 1; k<= 3; k++)
            //    {
            //        s0 = 2 * k - x;
            //        s1 += s0;
            //    }
            //}
            //Console.WriteLine(Math.Round(s1, 3));
            //Console.WriteLine(s1);

            int x;
            int sumd = 0;
            for (x=2; x<=5; x++)
            {
                for (int d=1; d<=x; d++)
                {
                    if (x%d==0)
                    {

                            sumd = sumd + d;

                    }
                }
            }

            Console.WriteLine(sumd);

            var result = ds.GetSumSeries(0.7, 1, 14);
            //Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}