// задать двумерный массив размером MxN,
// заполненный случайными числами

// mas = [[1, 2, 3], [4, 5, 6]]

using System;
using static System.Console;

int[,] GetRandomTwodimArray(int size1, int size2, int minValue, int maxValue){

    int[,] array = new int[size1,size2];

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
        array[i,j] = new Random().Next(minValue, maxValue);
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
        }
        WriteLine();
    }
}

Clear();
Write("Введите количество строк в массиве: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(ReadLine());

int[,] arr = GetRandomTwodimArray(rows, columns, 0, 10);
PrintArray(arr);


