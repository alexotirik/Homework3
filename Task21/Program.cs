/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void FindDistance(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    int DeltaX = (X2 - X1);
    int DeltaY = (Y2 - Y1);
    int DeltaZ = (Z2 - Z1);
    int step = 2;
    int x = Convert.ToInt32(Math.Pow(DeltaX, step));
    int y = Convert.ToInt32(Math.Pow(DeltaY, step));
    int z = Convert.ToInt32(Math.Pow(DeltaZ, step));
    double result = Math.Sqrt (x + y + z);
    Console.Write("Дистанция между точками = ");
    Console.Write(result.ToString("F" + 2));

}
Console.Write("ВВедите координату X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату X1: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Y1: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Z2: ");
int Z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты точки А: (" + X1 + ";" + Y1 + ";" + Z1 + ")");
Console.WriteLine("Координаты точки B: (" + X2 + ";" + Y2 + ";" + Z2 + ")");

FindDistance(X1, Y1, Z1, X2, Y2, Z2);