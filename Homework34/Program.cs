// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void PrintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}


int[]array= new int[25];
int x=0;
while (x<25)
{
array[x]= new Random().Next(100,1000);
x++; 
}
Console.WriteLine("Задан массив ");
PrintArray(array);

int ct=0;
foreach (var num in array)
{
     if (num %2==0)
     {
       ct++;
     }
}
Console.WriteLine($"В массиве {ct} четных чисел");