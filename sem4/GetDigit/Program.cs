// программа принимает на вход число
// и выбодит количество цифр в этом числе

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetDigit(int num){
    int result = 0;
    
    if(num < 0) num *= -1;

    while(num > 0){
        result += 1;
        num /= 10;

    }
    return result;
}
Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

Console.Write($"В числе {N}  {GetDigit(N)} цифр");