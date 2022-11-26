// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int a = new Random().Next(10,100);
Console.WriteLine (a);
int b = a/10;
int c = a%10;
int d = Math.Max(b,c);
// Console.WriteLine (b);Console.WriteLine (c);
Console.WriteLine (d);