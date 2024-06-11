using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_20_0_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для поиска в массиве:");
            if (int.TryParse(Console.ReadLine(), out int targetNumber))
            {
                RandomArray randomArray = new RandomArray(targetNumber);
                // Проверка, содержится ли искомое число в массиве
                bool isFound = randomArray.ContainsNumber();
                if (isFound)
                {
                    Console.WriteLine($"Число {targetNumber} найдено в массиве.");
                }
                else
                {
                    Console.WriteLine($"Число {targetNumber} не найдено в массиве.");
                }
            }
            Console.ReadKey();

        }
    }
}
