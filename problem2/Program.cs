// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3



Console.WriteLine("Введите первое число ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>y)
{
    Console.WriteLine($"Первое число {x} больше второго {y}"); 
}

else if (x<y)
{
 Console.WriteLine($"Первое число {x} меньше второго {y}"); 
}

else if (x==y)
{
 Console.WriteLine($"Первое число {x} равно второму {y}"); 
}
