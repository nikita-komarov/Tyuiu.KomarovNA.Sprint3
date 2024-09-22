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

            int x;
            double sp = 1;
            int i = 0;
            for (x = -2; x <= 2; x++) 
            {
                if (x == 0) 
                {
                    continue;
                }
                sp = sp * (2*x+2);
                i++;
            }
            Console.WriteLine(sp);



            var result = ds.GetSumSeries(0.7, 1, 14);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}