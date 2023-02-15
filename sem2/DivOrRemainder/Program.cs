// программа принимает на вход два числа и выводит, является ли второе
// число кратным первому.
// Если второе число не кратно первому, то выводим остаток от деления.

int dividend = new Random().Next(10, 100);
int divider = new Random().Next(1, 10);

if( dividend % divider == 0)
{
    Console.WriteLine($"{dividend} / {divider} = {dividend / divider}");
}
else
{
    Console.WriteLine($"Остаток от деления {dividend} на {divider}: {dividend % divider}");
}