// программа выводит сумму цифр числа

// 453 -> 12
// 45 -> 9

using System;
using static System.Console;

Clear();

Write("Введите число: ");
int num = int.Parse(ReadLine());
WriteLine(RecGetSum(num));

int RecGetSum(int n){

    if(n == 0){
        return 0;
    }
    int result = RecGetSum(n / 10) + (n % 10);
    return result;
}

