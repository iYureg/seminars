// Написать программу, которая принимает на вход координаты точки ( x, y )
// причем x != 0  и  y != 0 ивыдает номер четверти плоскости
// в которой находится эта точка.


Console.Clear();
Console.WriteLine("Введите Х: ");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите У: ");
int Y = int.Parse(Console.ReadLine());

if( X > 0 && Y > 0){
    Console.WriteLine("1");
}else if( X < 0 && Y > 0 ){
    Console.WriteLine("2");
}else if( X < 0 && Y < 0 ){
    Console.WriteLine("3");
}else if( X > 0 && Y < 0 ){
    Console.WriteLine("4");
}else if( X == 0 || Y == 0){
    Console.WriteLine("На оси");
}
