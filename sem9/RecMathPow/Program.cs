// возведение числа A в степень числа B
// через рекурсию
// A = 3; B = 5; -> 243
// A = 2; B = 3; -> 8


using System;
using static System.Console;

Clear();

Write("Введите число: ");
int num = int.Parse(ReadLine());
Write("Введите степень: ");
int pow = int.Parse(ReadLine());

WriteLine(GetPow(num, pow));
double GetPow(int n, int p){
    if(p < 0) p = 1;
    if(n == 0) return 0;
    if(p == 0) return 1;
    double result = n * GetPow(n, p - 1);
    return result;
}
