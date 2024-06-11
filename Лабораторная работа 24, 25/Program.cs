using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных пользователем
            Console.WriteLine("Введите скорость (в метрах в секунду): ");
            double speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите время (в секундах): ");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите силу (в ньютонах): ");
            double force = Convert.ToDouble(Console.ReadLine());
            // Создание объекта MovingObject
            MovingObject movingObject = new MovingObject(speed, time, force);

            // Вычисление и вывод результатов
            double distance = movingObject.CalculateDistance();
            double work = movingObject.CalculateWork();

            Console.WriteLine();
            Console.WriteLine($"Пройденное расстояние: {distance} метров");
            Console.WriteLine($"Количество работы, выполненной при прямолинейном перемещении: {work} Дж");


            Console.ReadKey();
        }
    }
}
