using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем фильмы и мультфильм
            Film film1 = new Film("Интерстеллар", "Кристофер Нолан", 169, 6);
            Film film2 = new Film("Аватар", "Джеймс Кэмерон", 162, 8);
            Cartoon cartoon = new Cartoon("Тачки", "Ежи Гофман", 117, 4);

            // Выводим информацию о них
            Console.WriteLine(film1.Information());
            Console.WriteLine(film2.Information());
            Console.WriteLine(cartoon.Information());

            Console.ReadKey();
        }
    }
}
