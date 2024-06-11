using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_26
{
    class Film
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Duration { get; set; } // Длительность в минутах
        public int ActorsCount { get; set; }

        public Film(string title, string director, int duration, int actorsCount)
        {
            Title = title;
            Director = director;
            Duration = duration;
            ActorsCount = actorsCount;
        }

        // Виртуальный метод для расчета стоимости фильма
        public virtual double Cost()
        {
            double baseCost = Duration * 20 + ActorsCount * 30;

            // Если режиссер Стивен Спилберг или Джеймс Кэмерон, удваиваем стоимость
            if (Director == "Стивен Спилберг" || Director == "Джеймс Кэмерон")
            {
                baseCost *= 2;
            }

            return baseCost;
        }
        public string Information()
        {
            return $"Название: {Title}, Режиссер: {Director}, Длительность: {Duration} мин, Количество актеров: {ActorsCount}, Стоимость: {Cost()} тыс. $";
        }
    }
}
