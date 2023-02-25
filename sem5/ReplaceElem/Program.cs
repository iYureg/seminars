// программа заменяет положительные элементы массива
// на соответствующие отрицательные и наоборот

// [ 2, 3, -7, 7 ] -> [ -2, -3, 7, -7 ]

int[] GetRandomArray(int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }

    return array;
}

int[] Replace(int[] arr){

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= (-1);
    }

    return arr;
}

Console.Clear();

int[] randArr = GetRandomArray(12);


Console.WriteLine($"[  {String.Join(", ", randArr)}  ]");
Console.WriteLine($"[  {String.Join(", ", Replace(randArr))}  ]");
