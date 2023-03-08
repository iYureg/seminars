// заменить строки думерного массива
// первый элемент первой строки
// становоится первым элементом последней стороки

// 1 2 3 -> 10 11 12 
// 4 5 6 -> 7 8 9
// 7 8 9 -> 4 5 6
// 10 11 12 -> 1 2 3

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

void ChangeArr(int[,] array){
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows / 2; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            int save = array[i, j];
            array[i, j] = array[rows - i -1, j];
            array[rows - i - 1, j] = save;
        }
    }
}

Clear();
Write("Введите количество строк в массиве: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(ReadLine());

int[,] arr = GetRandomTwodimArray(rows, columns, 0, 10);
PrintArray(arr);
ChangeArr(arr);
WriteLine();
PrintArray(arr);

