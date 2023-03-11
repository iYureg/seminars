// программа выводит числа от M до N 
// с помощью рекурсии

using System;
using static System.Console;

Clear();
WriteLine("Введите начало: ");
int M = int.Parse(ReadLine());
WriteLine("Введите конец: ");
int N = int.Parse(ReadLine());

WriteLine(PrintNumbers(M,N));

string PrintNumbers(int m, int n)
{
    if (m == n)
    {
        return n.ToString();
    }
    if (m > n) {
        int tempo = m;
        m = n;
        n = tempo;
    }

    string nums = PrintNumbers(m, n - 1) + ", " + n.ToString();
    return nums;
}



