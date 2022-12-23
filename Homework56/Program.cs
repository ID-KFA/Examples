// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void FindCoulmnNumber(int[] array)

{
    int min = array[0];
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i;
        }

    }
     Console.WriteLine($"Наименьшая сумма элементов находится в {index} строке массива");
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

int[] count = new int[4];


for (int i = 0; i < array.GetLength(0); i++)
{


    for (int j = 0; j < array.GetLength(1); j++)
    {


        {
            count[i] += array[i, j];
        }
    }
    // Console.WriteLine($"сумма строки {i} равна {count[i]}");
}


FindCoulmnNumber(count);



