//  программа пирнимает на вход число N
// и выдает таблицу квадратов от 1 до N включительно

Console.Clear();
// Console.WriteLine("Введите число от 1 до 10");
// int N = int.Parse(Console.ReadLine());

// if( N > 0 && N <= 10)
// {
//     for (int i = N; i >= 1; i--)
//     {
//         Console.WriteLine($"{i} * {i} = {Math.Pow(i, 2)}");
//     }
// }
// else
// {
//     Console.WriteLine($"Вы ввели: {N}");
// }


//--------------------------
// решение через массив

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int i = 1;
int m = N;

if( N < 0 )
{
    i = N;
    m = -N;
    N = -1;
}

int[] result = new int[m];
int j = 0;

for (; i <= N; i++)
{
    result[j] = i * i;
    j++;
} 
for (j = 0; j < m; j++) Console.Write($"{result[j]} ");