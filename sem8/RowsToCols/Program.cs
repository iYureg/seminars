// в думерном массиве заменить ряды на столбцы
// если это возможно

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
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int[,] swap(int[,] arr, int size)
    {
        int[,] transp = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
                transp[i, j]= arr[j, i];
        }
        return transp;
    }

bool CheckRowCol(int[,] arr){
    return arr.GetLength(0) == arr.GetLength(1);
}

Clear();
Write("Введите количество строк в массиве: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(ReadLine());

int[,] arr = GetRandomTwodimArray(rows, columns, 0, 10);
if(CheckRowCol(arr))
{
    PrintArray(arr);
    WriteLine();
    int[,] swapArr = swap(arr, rows);
    PrintArray(swapArr);
}
else
{
    WriteLine("Матрица не симетрична: ");
    PrintArray(arr);
}

