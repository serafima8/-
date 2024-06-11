using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_20
{
    class Program
    {
        // метод Main является асинхронным и возвращает объект Task
        static async Task Main(string[] args)
        {
            // Установка размеров матрицы
            int rows = 5; // количество строк
            int cols = 5; // количество столбцов

            // Генерация матрицы случайных чисел
            int[,] matrix = GenerateRandomMatrix(rows, cols);

            // Вывод исходной матрицы
            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            // Преобразование матрицы
            double[,] transformedMatrix = TransformMatrix(matrix);

            // Вывод преобразованной матрицы
            Console.WriteLine("\nПреобразованная матрица:");
            PrintMatrix(transformedMatrix);
            Console.ReadKey();
        }

        // Метод для генерации матрицы случайных чисел
        static int[,] GenerateRandomMatrix(int rows, int cols)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(-10, 11); // Генерация чисел от -10 до 10
                }
            }
            return matrix;
        }

        // Метод для вывода матрицы целых чисел
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],6} "); // Выводим элементы с выравниванием по ширине
                }
                Console.WriteLine();
            }
        }

        // Метод для вывода матрицы вещественных чисел
        static void PrintMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],10:F4} "); // Выводим элементы с выравниванием и 4 знаками после запятой
                }
                Console.WriteLine();
            }
        }

        // Метод для преобразования матрицы
        static double[,] TransformMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0); //возвращает количество строк в матрице matrix
            int cols = matrix.GetLength(1); //возвращает количество столбцов в матрице matrix.
            double[,] transformedMatrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int element = matrix[i, j];
                    if (element % 2 != 0) // Проверка на нечетность
                    {
                        double tanValue = Math.Tan(element);
                        double cotValue = 1.0 / Math.Tan(element); // Вычисляем котангенс как 1/тангенс
                        transformedMatrix[i, j] = tanValue + cotValue; // Сумма тангенса и котангенса
                    }
                    else
                    {
                        transformedMatrix[i, j] = element; // Если число четное, оставляем без изменений
                    }
                }
            }

            return transformedMatrix;
        }

    }
}
