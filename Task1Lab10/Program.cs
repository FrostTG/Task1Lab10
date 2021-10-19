using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Введите значение градусов угла");
                    int g = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение минут угла");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение секунд угла");
                    int s = Convert.ToInt32(Console.ReadLine());
                    Corner corner = new Corner(g, m, s);
                    double R = ToRadians(corner.Gradus, corner.Minute, corner.Sec);
                    Console.WriteLine();
                    if (g <= 360 && g >= 0 && m <= 60 && m >= 0 && s <= 60 && s >= 0)
                    {
                        Console.WriteLine("Задан угол в {0} градусов {1} минут {2} секунд \nили {3:f2} радиан", g, m, s, R);
                    }
                    else
                    {
                        Console.WriteLine("Введены некорректные значения угла! Повторите попытку");
                    }
                    Console.ReadKey();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    Console.ReadLine();
                    continue;

                }

            }
        }
        static double ToRadians(double g, double m, double s)
        {
            double Gr = g + (((m + s) / 60)) / 60;
            double R = Gr * Math.PI / 180;
            return R;
        }
    }
    class Corner
    {
        private int gradus;
        private int minute;
        private int sec;
        public int Gradus
        {
            set
            {
                if (value <= 360 && value >= 0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Значение градусов должно быть от 0 до 360");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Minute
        {
            set
            {
                if (value <= 60 && value >= 0)
                {
                    minute = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Значение минут должно быть от 0 до 60");
                }
            }
            get
            {
                return minute;
            }
        }
        public int Sec
        {
            set
            {
                if (value <= 60 && value >= 0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Значение секунд должно быть от 0 до 60");
                }
            }
            get
            {
                return sec;
            }
        }
        public Corner(int gradus, int minute, int sec)
        {
            Gradus = gradus;
            Minute = minute;
            Sec = sec;
        }
    }
}