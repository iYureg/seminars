// по заданному номеру четверти,
// показать диапозон возможных координат точек в этой четверти ( x, y )


Console.Clear();
Console.WriteLine("Введите число -> 1 - 4: ");
int quarter = int.Parse(Console.ReadLine());


if( quarter == 1 ){
    Console.WriteLine("x > 0 и y > 0");
}else if( quarter == 2 ){
    Console.WriteLine("X < 0 и Y > 0");
}else if( quarter == 3 ){
    Console.WriteLine("X < 0 и Y < 0");
}else if( quarter == 4 ){
    Console.WriteLine("X > 0 и Y < 0");
}else if( quarter <= 0 || quarter >= 5 ){
    Console.WriteLine($"Вы ввели: {quarter}");
}


// решение из семинара

Console.Write("Введите номер четверти: ");
int quart = int.Parse(Console.ReadLine());

switch (quart)
{
    case 1:{
            Console.WriteLine("x > 0 и y > 0");
            break;
        }
    case 2:{
            Console.WriteLine("X < 0 и Y > 0");
            break;
        }
    case 3:{
            Console.WriteLine("X < 0 и Y < 0");
            break;
        }
    case 4:{
            Console.WriteLine("X > 0 и Y < 0");
            break;
        }
    default:{
            Console.WriteLine("Введена неправильная четверть");
            break;
        }
}