// принимаем два числа и проверяем,
// является ли одно число квадратом другого.

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

// int num1 = new Random().Next(2, 25);
// int num2 = new Random().Next(2, 25);

if(num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.WriteLine($"первое число: {num1}, второе число: {num2} -> да ");
}
else
{

    Console.WriteLine($"первое число: {num1}, второе число: {num2} -> нет");
}