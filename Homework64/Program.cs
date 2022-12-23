// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string nums = " ";

void Nat(int num)

{

    if (num == 1) nums = nums+" 1";
    else
    {
        nums = nums+" "+ Convert.ToString(num);
        Nat(num - 1);
    }

}
Console.WriteLine("Введите N ");
int x = Convert.ToInt32(Console.ReadLine());

Nat(x);

Console.WriteLine(nums);