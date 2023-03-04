﻿// задать двумерный массив, m на n 
// каждый элемент в массиве находится по формуле A[i,j] = i + j
// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5





using System;
using static System.Console;

int[,] GetRandomTwodimArray(int size1, int size2){

    int[,] array = new int[size1,size2];

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
        array[i,j] = i + j;
        }
    }

    return array;
}
void PrintArray(int[,] inArray){
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}");
            Write(" ");
        }
        WriteLine();
    }
}

Clear();
Write("Введите количество строк в массиве: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(ReadLine());

int[,] arr = GetRandomTwodimArray(rows, columns);
PrintArray(arr);
