// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

int result=x;
int len=0;
int y;

//Находим количество символов в числе
while (x>0)
{
y= x%10;
x = x/10;

len++; 
}

if (len>1) 

//Наполняем массив символами
{
int[]array= new int[len];

x=result;
len=0;

while (x>0)
{
y= x%10;
x = x/10;
array[len]=y;
len++; 
}

//Копируем массив
var array2 = (int[])array.Clone();

//Разворачиваем массив
Array.Reverse(array);

//Сравниваем значения двух массивов
if (string.Join(",", array) == string.Join(",", array2))

{
Console.WriteLine($"Число {result} палиндром");
}
else 
{
Console.WriteLine($"Число {result} не палиндром");
}

}
else
{
    Console.WriteLine($"Ваше число {result} слишком короткое");
}