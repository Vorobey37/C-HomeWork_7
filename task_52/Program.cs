/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
using System;
using static System.Console;
Clear();

double[,] GetArray(int rows, int columns, int minRandomValue, int maxRandomValue)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minRandomValue, maxRandomValue + 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

double[] GetSum(double[,] array)
{
    double[] sum = new double[array.GetLength(1)];
    double result = 0;
    for (int index = 0; index < sum.Length; index++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i, index];
        }
        sum[index] = result / array.GetLength(0);
        result = 0;
    }
    return sum;
}

void PrintGetSum(double[] array, int number) 
// где number - это максимальное количество знаков, выводимых после запятой
{
    Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(array[i], number);
        Write($"{array[i]}; ");
    }
}

double[,] array = GetArray(7, 7, -10, 10);
PrintArray(array);
double[] result = GetSum(array);
PrintGetSum(result, 2);
