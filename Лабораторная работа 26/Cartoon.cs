using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_26
{
    class Cartoon : Film
    {
        public Cartoon(string title, string director, int duration, int actorsCount) : base(title, director, duration, actorsCount)  { }

        // Переопределение метода для расчета стоимости мультфильма
        public override double Cost()
        {
            return Duration * 25 + ActorsCount * 10;
        }
    }
}
