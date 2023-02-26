// найти в массиве случайных чисел от 0 до 150,
// колличество чисел в промежутке от 10 до 99 включительно

int[] GetRandomArray(int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 150);
    }

    return array;
}

int CountValues(int[] arr, int leftR, int rightR){
    int count = 0;

    foreach(var elem in arr){
        if( elem >= leftR && elem <= rightR ) count++;
    }

    return count;
}

int[] randomArr = GetRandomArray(123);


Console.WriteLine($"[ {String.Join(", ", randomArr)}  ]");
Console.WriteLine($"Количество элементов в отрезке 10 - 99: {CountValues(randomArr, 10, 100)}");
