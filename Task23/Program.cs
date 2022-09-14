/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void NumCube(int N, int count)
{
    Console.Write("Таблица кубов от 1 до " + N + ": ");
    while(count <= N)
    {
        int num = count * count * count;
        Console.Write(num + ", ");
        count++;
    }
}
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
NumCube(N, count);