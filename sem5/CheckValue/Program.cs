// программа определяет присутствует ли заданное числа в массиве
// 4; массив[6, 7, 19, 345, 3] -> нет
// 3; массив[6, 7, 19, 345, 3] -> да

int[] GetArrayFromString(string arr){
    string[] array = arr.Split(" ");
    int[] result = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        result[i] = int.Parse(array[i]);
    }

    return result;
}


bool CheckValue(int[] array, int value){
    
    foreach (int item in array)
    {
        if(item == value) return true;
    }
    return false;
}

Console.Clear();


Console.Write("Введите элементы массива через пробел: ");
string arrayString = Console.ReadLine();

Console.Write("Введите искомое число: ");
int value = int.Parse(Console.ReadLine());

string result = CheckValue(GetArrayFromString(arrayString), value) ? "Yes" : "No";

Console.Write($"[ {String.Join(", ", GetArrayFromString(arrayString))} ] -> {result}");

