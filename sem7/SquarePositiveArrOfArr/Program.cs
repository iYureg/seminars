// найти элементы двумерного массива,
// у которых оба индекса четные, 
// и возвести их в квадрат

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

// void ChangePositiveItems(int[,] arr){
//     for (int i = 1; i < arr.GetLength(0); i += 2)
//     {
//         for (int j = 1; j < arr.GetLength(1); j += 2)
//         {
//             arr[i, j] = arr[i, j] * arr[i, j];
//         }
//     }
// }

int[,] ChangeArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                // arr[i, j] *= arr[i, j];
                arr[i, j] = Convert.ToInt32(Math.Pow(arr[i, j], 2));
            }
        }
    }
    return arr;
}

Clear();
Write("Введите количество строк в массиве: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(ReadLine());

int[,] arr = GetRandomTwodimArray(rows, columns);
PrintArray(arr);
WriteLine();
// ChangePositiveItems(arr);
arr = ChangeArray(arr);
PrintArray(arr);

