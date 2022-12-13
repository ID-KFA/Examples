// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
    }
}


int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 5);
    }
}


Console.WriteLine("Задан массив ");
PrintArray(array);

for (int i = 0; i < array.GetLength(1); i++)

{
    int count = 0;

    for (int j = 0; j < array.GetLength(0); j++)
    {
        count += array[j, i];
    }

    Console.WriteLine($"Среднее арифметическое {i}-го столбца: {Math.Round((double)count / (double)array.GetLength(0), 1)}");
}


