// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void PrintArray(int[,] array)
{

for (int i=0;i<array.GetLength(0);i++)
{
   for (int j=0;j<array.GetLength(1);j++) 
   {
    Console.Write($"{array[i,j]}");
   }
Console.WriteLine();
}
}


int[,]array= new int[3,4];

for (int i=0;i<array.GetLength(0);i++)
{
   for (int j=0;j<array.GetLength(1);j++) 
   {
    array[i,j]= i+j;
   }
}


Console.WriteLine("Задан массив ");
PrintArray(array);

Console.WriteLine("Введите номер строки ");
int row = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите номер колонки ");
 int column = Convert.ToInt32(Console.ReadLine());

 try
{
    Console.WriteLine($"Найдено число в массиве {array[row,column]}"); 
}
catch
{
    Console.WriteLine($"Число в массиве не найдено");  
}
