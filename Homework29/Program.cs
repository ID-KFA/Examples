// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

int[]array= {1,4,56,32,5,788,9,53};


PrintArray(array);