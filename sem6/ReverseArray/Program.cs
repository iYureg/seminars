// программа переворачивает одномерный массив
// [1,2,3,4,5] -> [5,4,3,2,1]

int[] GetRandomArray(int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
    }

    return array;
}
int[] ReverseArr1(int[] arr){
    int[] resultArr = new int[arr.Length];
    int length = resultArr.Length;

    for (int i = 0; i < arr.Length; i++)
    {
        resultArr[length - 1] = arr[i];
        length--;
    }
    return resultArr;
}
void ReverseArr2(int[] arr){
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int save = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = save;

    }
}

int[] array = GetRandomArray(10);
int[] reversedArray = ReverseArr1(array);

Console.Clear();

Console.WriteLine($"ReverseArr1: [ {String.Join(", ", array)} ] -> [ {String.Join(", ", reversedArray)} ]");
Console.Write($"ReverseArr2: [ {String.Join(", ", array)} ] -> ");
ReverseArr2(array);
Console.Write($"[ {String.Join(", ", array)} ]");