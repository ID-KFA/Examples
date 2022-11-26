// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
int first;
int second;
int result;

Console.WriteLine("Введите первое число ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>y)
{
    first=x; 
second=y;
}
else 
{
first=y; 
second=x;
}

result=second*second;

if (result==first)
{
   Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет");
}