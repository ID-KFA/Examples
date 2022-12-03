// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int exp(int a, int b)
{
int s=a;
for (int i = 1; i < b; i++)
{
    a=a*s;
}
return a;
}


Console.WriteLine("Введите первое число ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int y = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"{x} в степени {y} равно {exp(x,y)}"); 