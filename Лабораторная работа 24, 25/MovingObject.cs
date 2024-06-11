using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_24
{
    class MovingObject : Journey
    {
        //  сила, приложенная к движущему объекту
        public double Force { get; set; }

        public MovingObject(double speed, int time, double force) : base(speed, time)
        {
            Force = force;
        }

        // Метод для расчета количества работы, выполненной при прямолинейном перемещении объекта
        public double CalculateWork()
        {
            // Расстояние в метрах, вычисленное из базового класса
            double distance = CalculateDistance();

            // Расчет работы
            return Force * distance;
        }
    }
}
