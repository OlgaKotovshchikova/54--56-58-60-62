using System;

namespace _54_56_58_60_62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер задачи 54, 56, 58, 60, 62: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {
                case 54:
                    TaskFiftyfour();
                    break;
                /*case 56:
                    TaskFiftysix();
                    break;
                case 58:
                    TaskFiftyeight();
                    break;
                case 60:
                    TaskSixty();
                    break;
                case 62:
                    TaskSixtytwo();
                    break;*/
                default:
                    Console.WriteLine("Такой задачи не существует");
                    break;
            }
        }
        #region Задача 54
        /*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        В итоге получается вот такой массив:
        7 4 2 1
        9 5 3 2
        8 4 4 2*/

        static void TaskFiftyfour()
        {
            int[,] FillArray(int rows, int columns)
            {
                int[,] matrix = new int[rows, columns];
                Random rand = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rand.Next(1, 10);
                    }
                }
                return matrix;
            }

            void PrintArray(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            void SortMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        for (int k = j+1; k < matrix.GetLength(1); k++)
                        {
                            if (matrix[i, j] < matrix[i, k])
                            {
                                int temp = matrix[i, j];
                                matrix[i, j] = matrix[i, k];
                                matrix[i, k] = temp;
                            }
                        }
                    }
                }
            }

            int[,] matrix = FillArray(5, 8);
            PrintArray(matrix);
            SortMatrix(matrix);
            PrintArray(matrix);
        }
        #endregion
    }
}
