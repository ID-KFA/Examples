// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void PrintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}


int[]array= new int[5];
int x=0;
while (x<5)
{
array[x]= new Random().Next(0,10);
x++; 
}
Console.WriteLine("Задан массив ");
PrintArray(array);

int ct=0;
int sum =0;
foreach (var num in array)
{
   ct++;
     if (ct%2 !=0)
     {
       sum=sum+num;
     }
}
Console.WriteLine($"Сумма чисел на нечетных позициях: {sum}");