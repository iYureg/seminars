// программа принимает на вход 3 числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

// !каждая стороно треугольника меньше суммы двух других

bool CheckTriangle(int a, int b, int c){
    bool flag = a + b > c && b + c > a && a + c > b ? true : false;
    return flag;
}

Console.Write("Введите сторону A: ");
int aSide = int.Parse(Console.ReadLine());


Console.Write("Введите сторону B: ");
int bSide = int.Parse(Console.ReadLine());


Console.Write("Введите сторону C: ");
int cSide = int.Parse(Console.ReadLine());

string result = CheckTriangle(aSide, bSide, cSide) ? "Yes" : "No";

Console.WriteLine($"{result}");


if(CheckTriangle(aSide,bSide,cSide)){
    Console.Write("Да");
}else{
    Console.Write("Нет");
}