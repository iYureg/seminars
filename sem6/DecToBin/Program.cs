// программа преобразовывает десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string GetBin(int dec, int otherSystem)
{    
    string res = String.Empty;
    string nums = "0123456789ABCDEF";

    while (dec > 0)
    {
        res = nums[dec%otherSystem] + res;
        dec /= otherSystem;
    }
    return res;
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"[ {GetBin(N, 2)} ]");




