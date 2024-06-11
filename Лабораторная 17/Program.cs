using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_17
{
    class Program
    {
        // Тип делегата, представляющий асинхронный метод поиска
        delegate Task<bool> SearchDelegate(int number, int[] array);

        static async Task Main(string[] args)
        {
            // Генерация массива случайных чисел
            Random random = new Random();
            int[] randomArray = Enumerable.Range(0, 100).Select(_ => random.Next(0, 100)).ToArray();
            int numberToFind = 42; // Пример числа, которое нужно найти

            // Асинхронный метод поиска с использованием лямбда-выражения
            SearchDelegate searchAsync = async (number, array) =>
            {
                await Task.Delay(100); // Небольшая задержка для эмуляции асинхронной работы
                // Поиск числа в массиве
                return array.Contains(number);
            };

            // Обратный вызов для обработки результата
            Action<bool> callback = result =>
            {
                if (result)
                {
                    Console.WriteLine($"Число {numberToFind} найдено в массиве.");
                }
                else
                {
                    Console.WriteLine($"Число {numberToFind} не найдено в массиве.");
                }
            };

            // Вызов асинхронного метода и передача результата в callback
            bool found = await searchAsync(numberToFind, randomArray);
            callback(found);

            Console.ReadKey();
        }
    }
}
