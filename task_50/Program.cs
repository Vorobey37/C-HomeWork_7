/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/
using System;
using static System.Console;

int[,] GetArray(int rows, int columns, int minRandom, int maxRandom)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return array;
}

void PrintArray(int [,]array)
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

void FindElement (int [,]array, int rowPosition, int columnPosition)
{
    int element;
    if (rowPosition<array.GetLength(0) && columnPosition<array.GetLength(1))
    {
        element = array[rowPosition, columnPosition];
        WriteLine (element);
    }
    else WriteLine ("такого элемента нет в массиве");
}

Clear();
WriteLine("Введите значение строки:");
int rowPosition = int.Parse(ReadLine());
WriteLine("Введите значение столбца:");
int columnPosition = int.Parse(ReadLine());
int [,]array = GetArray(5, 5, 1, 10);
PrintArray(array);
WriteLine();
Write ($"{rowPosition}{columnPosition} -> ");
FindElement(array, rowPosition, columnPosition);




