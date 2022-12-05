// }
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void PrintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

int[]array= new int[12];

int x=0;
while (x<12)
{
array[x]= new Random().Next(-9,10);
x++; 
}
Console.WriteLine("Задан массив ");
PrintArray(array);


//Копируем массив
var array2 = (int[])array.Clone();

//Разворачиваем массив
Array.Reverse(array);
Console.WriteLine("Развернутый массив ");
PrintArray(array);

int[]result= new int[12];

for (int s = 0; s < 12; s++)
{
  result[s]=array[s]*array2[s];
}

Console.WriteLine("Получен массив ");
PrintArray(result);
