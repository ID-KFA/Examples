// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


int[,] array = new int[4, 4];



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
    }
}

Console.WriteLine("Задан массив ");
PrintArray(array);

int temp = 0;


for (int i = 0; i < array.GetLength(0); i++)
{
    
    for (int y = 0; y < array.GetLength(1); y++)
    {

    for (int j = 0; j < array.GetLength(1)-1; j++)
    {
        if (array[i, j] < array[i, j + 1])

        {
            temp = array[i, j];
            array[i, j] = array[i, j + 1];
            array[i, j + 1] = temp;

        }
    }
}

}

Console.WriteLine("Получен массив ");

PrintArray(array);