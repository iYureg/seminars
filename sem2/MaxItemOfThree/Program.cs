// программа выводит случаяное трехзначное число
// и удаляет вторую цифру этого числа

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
int hundreds = num / 100;
int decades = (num - (hundreds * 100)) / 10;
int remains = num % 10;

int result = hundreds * 10 + remains;

Console.WriteLine($"{num} - {hundreds} - {decades} - {remains} - {result}");
Console.WriteLine($"Результат: {result}");