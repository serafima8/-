using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Лабораторная_работа_23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод текущей системной даты и времени
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Текущая системная дата и время: " + currentDate.ToString("yyyy-MM-dd HH:mm:ss"));

            // Ввод данных о телепередаче
            Console.WriteLine("Введите время начала выхода в эфир телепередачи (в формате HH:mm): ");
            string startTimeInput = Console.ReadLine();
            TimeSpan startTime;
            while (!TimeSpan.TryParse(startTimeInput, out startTime))
            {
                Console.WriteLine("Неверный формат времени. Пожалуйста, введите время в формате HH:mm: ");
                startTimeInput = Console.ReadLine();
            }

            Console.WriteLine("Введите продолжительность телепередачи в секундах: ");
            int durationInSeconds;
            while (!int.TryParse(Console.ReadLine(), out durationInSeconds) || durationInSeconds <= 0)
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите положительное целое число секунд: ");
            }

            // Расчет времени окончания телепередачи
            TimeSpan duration = TimeSpan.FromSeconds(durationInSeconds);
            TimeSpan endTime = startTime.Add(duration);

            // Расчет продолжительности в минутах
            int durationInMinutes = (int)Math.Ceiling(duration.TotalMinutes);

            // Расчет количества рекламных пауз (каждые 5 минут)
            int adIntervalMinutes = 5;
            int numberOfAdBreaks = durationInMinutes / adIntervalMinutes;

            // Вывод результатов
            Console.WriteLine();
            Console.WriteLine("Время начала выхода в эфир: " + startTime.ToString(@"hh\:mm"));
            Console.WriteLine("Время окончания телепередачи: " + endTime.ToString(@"hh\:mm"));
            Console.WriteLine("Продолжительность телепередачи: " + durationInMinutes + " минут");
            Console.WriteLine("Количество рекламных пауз: " + numberOfAdBreaks);

            Console.ReadKey();
        }
    }
}



