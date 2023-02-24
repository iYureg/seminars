// программа принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

int seven = 7;
int tweThree = 23;
bool flag = false;

Console.WriteLine("Введите число: ");
//int dividend = int.Parse(Console.ReadLine());
int dividend = new Random().Next(10, 1000);


if(dividend % seven == 0 && dividend % tweThree == 0)
{
    flag = true;
}

Console.WriteLine($"{dividend} -> {flag}");