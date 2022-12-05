// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void PrintArray(double[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}


double[]array= new double[5];
int x=0;
while (x<5)
{
array[x]= new Random().NextDouble();
x++; 
}
Console.WriteLine("Задан массив ");
PrintArray(array);

double max=0;
double min=1;
foreach (var num in array)
{
   
     if (num>max) max=num;
  if (num<min) min=num;  
}
Console.WriteLine($"min {min}");
Console.WriteLine($"max {max}");
Console.WriteLine($"Максимальная разница элементов массива равна {max-min}");