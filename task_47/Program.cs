/*
    Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
using System;
using static System.Console;
Clear();

double[,] GetArray(int rows, int columns, int minRandom, int maxRandom)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //чтобы в итоге был точно диапазон [minRandom, maxRandom] из вещественных чисел
            array[i, j] = new Random().Next(minRandom + 1, maxRandom + 1) - new Random().NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array, int numbers)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //ограничим количество цифр после запятой
            array[i, j] = Math.Round(array[i, j], numbers);
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}
/*подразумевается, что пользователь будет адекватно вводить данные:
столбцы и строки будут натуральные, minRandom будет точно меньше, чем maxRandom,
а количество цифр после запятой будет не меньше нуля и не более максимального значения для типа double*/
WriteLine("Введите количество строк массива:");
int rows = int.Parse(ReadLine());
WriteLine("Введите количество столбцов массива:");
int columns = int.Parse(ReadLine());
WriteLine("Введите минимальный предел для элементов массива:");
int minRandom = int.Parse(ReadLine());
WriteLine("Введите максимальный предел для элементов массива:");
int maxRandom = int.Parse(ReadLine());
WriteLine("Введите количество цифр после , для элемента массива:");
int numbers = int.Parse(ReadLine());
double[,] array = GetArray(rows, columns, minRandom, maxRandom);
PrintArray(array, numbers);
