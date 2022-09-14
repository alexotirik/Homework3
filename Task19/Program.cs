/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
string Palindrom(string num)
{
    if(num[0] == num[4] && num[1] == num[3])
        return num + "-> да";
    else
        return num + "-> нет";
}

Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(a);
Console.WriteLine(Palindrom(num));