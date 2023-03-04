// 

using System;
using static System.Console;

int[,] GetRandomTwodimArray(int size1, int size2){

    int[,] array = new int[size1,size2];

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array[i, j] = i + j;
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

int GetDiagSum(int[,] arr){
    int length = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        result += arr[i, i];    
    }
    return result;
}

Clear();
Write("Введите количество строк в массиве: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(ReadLine());

int[,] arr = GetRandomTwodimArray(rows, columns);
PrintArray(arr);
WriteLine();

WriteLine($"Сумма элементов по диагонали -> {GetDiagSum(arr)}");

