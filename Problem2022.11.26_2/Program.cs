﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int a = new Random().Next(100,1000);
Console.WriteLine (a);
int b = a/100;
int c = a%10;

Console.Write("Ответ: ");
Console.Write(b);
Console.Write(c);
Console.WriteLine();
