// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
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

if (len>2) 

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
//Разворачиваем массив
Array.Reverse(array);

//Находим ответ
Console.WriteLine($"Третья цифра числа: {array[2]}");

}
else 
Console.WriteLine($"Вы ввели слишком короткое число");



