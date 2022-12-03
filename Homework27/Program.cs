// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


void sum(int x) //Определяет сумму цифр в числе
{
int y;
int result=0;
while (x>0)
{
y= x%10;
result+=y;
x = x/10; 
}
Console.WriteLine($"Cумма символов в числе {result}");
}

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

sum(x);