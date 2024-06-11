using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Лабораторная_19
{
    //Класс Thread в C# предоставляет способ создавать и управлять потоками напрямую. Использование Thread может быть полезно в различных ситуациях, когда нужно реализовать параллельное выполнение задач. 
    class Program
    {
        // Метод для вычисления статистики символов
        static void Calc(object input)
        {
            // Преобразуем входной параметр к типу строки
            string text = input as string;
            if (text == null)// Проверяем, что входной параметр - строка
            {
                Console.WriteLine("Неверный тип входных данных.");
                return;
            }

            // Словарь для хранения частоты каждого символа
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            // Подсчет количества каждого символа в строке
            foreach (char c in text)
            {
                if (characterCount.ContainsKey(c))
                {
                    characterCount[c]++;
                }
                else
                {
                    characterCount[c] = 1;
                }
            }

            // Вывод результатов статистики
            Console.WriteLine("Статистика символов:");
            foreach (var pair in characterCount)
            {
                Console.WriteLine($"Символ '{pair.Key}': {pair.Value}");
            }
        }

        static void Main(string[] args)
        {
            // Запрашиваем у пользователя ввод строки
            Console.WriteLine("Введите строку для анализа:");
            string inputString = Console.ReadLine();
            // Создание и запуск потока для вычисления статистики символов
            Thread statisticsThread = new Thread(Calc);
            statisticsThread.Start(inputString);

            // Ожидание завершения работы потока
            statisticsThread.Join();

            Console.WriteLine("Основной поток завершён.");

            Console.ReadKey();
        }
    }
}
