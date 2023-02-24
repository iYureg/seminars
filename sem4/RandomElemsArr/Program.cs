// программа заполняет массив из восьми элементов
// нулями и еденицами в случайном порядке

int[] GetRandomElem(int size){
    int[] array = new int[size];

    int length = array.Length;

   for (int i = 0; i < length; i++)
   {
        array[i] = new Random().Next(2);
    }

    return array;
}

int[] arr = GetRandomElem(16);

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]}");
// }

Console.WriteLine($"[  {String.Join(", ", arr)}  ]");
