// программа принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

// A (3, 6); B(2, 1) -> 5.09
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09

// A (7, -5); B(1, -1) -> 7.21
//sqrt((7 - 1)^2 + (-5 -(-1))^2) = 7.21

double GetDistance(int[] arr1, int[]arr2)
{
    double result = Math.Pow(arr1[0] - arr2[0],2) + Math.Pow(arr1[1] - arr2[1], 2);
    return Math.Sqrt(result);
}

int[] A = new int[2];
int[] B = new int[2];

Console.Clear();
Console.Write("Введите x первой точки: ");
A[0] = int.Parse(Console.ReadLine());

Console.Write("Введите y первой точки: ");
A[1] = int.Parse(Console.ReadLine());

Console.Write("Введите x второй точки: ");
B[0] = int.Parse(Console.ReadLine());

Console.Write("Введите y второй точки: ");
B[1] = int.Parse(Console.ReadLine());


Console.WriteLine($"Расстояние между точками -> {GetDistance(A, B):f3}");