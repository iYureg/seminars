// программа принимает на вход случайные числа от -9 до 9
// и выводит суммы позитивных и негативных чисел

int[] GetRandomArray(int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }

    return array;
}

int[] SumArr(int[] arr)
{
    int[] resultArr = new int[2];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) resultArr[0] += arr[i];
        else resultArr[1] += arr[i];
    }

    return resultArr;
}
Console.Clear();

int[] randomArr = GetRandomArray(12);
int[] result = SumArr(randomArr);

Console.WriteLine($"Массив сучайных чисел: [ {String.Join(", ", randomArr)} ]");
Console.WriteLine($"Суммы положительных и отрицательных элементов: {String.Join(", ", result)}");
