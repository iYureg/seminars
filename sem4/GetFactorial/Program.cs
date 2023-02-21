// принимаем на вход число N
// и выводит произведение всех сислел от 1 до N

int GetFactorial(int num)
{
    int result = 1;

    int i = 2;

    if (num < 0)
    {
        i = num;
        num = - 1;
    }

    for (; i <= num; i++)
    {
        result *= i;

    }
        return result;
}
Console.Clear();
Console.Write("Введите число: ");

int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Произведение чисел от {N} -> {GetFactorial(N)}");

