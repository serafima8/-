using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_20_0_
{
    class RandomArray
    {
        private int[] numbers; // Массив случайных чисел
        private int targetn; // Искомое число

        // Конструктор класса, инициализирующий массив случайных чисел
        public RandomArray(int target)
        {
            targetn = target; // Установка значения искомого числа

            Random random = new Random(); 
            int arraySize = random.Next(10, 101); 
            numbers = new int[arraySize]; // Инициализация массива чисел заданного размера
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = random.Next(0, 101); // Заполнение массива случайными числами от 0 до 100
            }
            Console.WriteLine("Сгенерированный массив:"); 
            Console.WriteLine(string.Join(", ", numbers)); // Вывод сгенерированного массива в строку
        }

        // Метод для проверки наличия искомого числа в массиве
        public bool ContainsNumber()
        {
            foreach (int number in numbers)
            {
                if (number == targetn)
                {
                    return true; // Возвращаем true, если число найдено в массиве
                }
            }
            return false;
        }

    }
}
