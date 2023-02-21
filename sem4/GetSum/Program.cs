// программа принимает на вход число А
// и выдает сумму чисел от 1 до А

int GetSum(int n){
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число A: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {num} = {GetSum(num)}");