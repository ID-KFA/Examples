// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую ");
string s = Console.ReadLine();
string[] nums = s.Split(',');
int count = 0;
foreach (var num in nums)
{
    Console.WriteLine(num);
    if (int.Parse(num) > 0) count++;
}

Console.WriteLine($"Вы ввели {count} положительных чисел");