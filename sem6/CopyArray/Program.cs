// написать программу, которая делает копию массива
// с помощью поэлементного копирования
int[] GetRandomArray(int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }

    return array;
}

int[] GetArrayCopy(int[] arr){
    int[] copy = new int[arr.Length];

    for (int i = 0; i < copy.Length; i++)
    {
        copy[i] = arr[i];
    }

    return copy;
}

int[] randomArr = GetRandomArray(10);
int[] copyArr = GetArrayCopy(randomArr);
Console.WriteLine($"[ {String.Join(", ", randomArr)} ] copy -> [ {String.Join(", ", copyArr)} ]");
