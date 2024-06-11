using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_24
{
    class Journey
    {
        //  скорость в метрах в секунду
        public double Speed { get; set; }

        //  время в секундах
        public int Time { get; set; }
        public Journey(double speed, int time)
        {
            Speed = speed;
            Time = time;
        }

        // Метод для вычисления пройденного расстояния (в метрах)
        public double CalculateDistance()
        {
            return Speed * Time;
        }
    }
}
