// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели");
int x = Convert.ToInt32(Console.ReadLine());

if (x==6 || x==7)
{

    Console.WriteLine("Это выходной");
}

else  
{
    Console.WriteLine("Это рабочий день");
}
