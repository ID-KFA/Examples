//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

// void FindCoulmnNumber(int[] array)

// {
//     int min = array[0];
//     int index = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (min > array[i])
//         {
//             min = array[i];
//             index = i;
//         }

//     }
//      Console.WriteLine($"Наименьшая сумма элементов находится в {index} строке массива");
// }



int[,] FillArray(int col, int row)
{
    int[,] array = new int[col, row];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;

}

int[,] MultiMatrix(int[,] array1, int[,] array2)
{
    int[,] array = new int[2, 2];

    array[0, 0] = array1[0, 0] * array2[0, 0] + array1[0, 1] * array2[1, 0];
    array[0, 1] = array1[0, 0] * array2[0, 1] + array1[0, 1] * array2[1, 1];
    array[1, 0] = array1[1, 0] * array2[0, 0] + array1[1, 1] * array2[1, 0];
    array[1, 1] = array1[1, 0] * array2[0, 1] + array1[1, 1] * array2[1, 1];

    return array;

}

int[,] array1 = FillArray(2, 2);
int[,] array2 = FillArray(2, 2);
Console.WriteLine("Задан массив 1 ");
PrintArray(array1);
Console.WriteLine("Задан массив 2 ");
PrintArray(array2);

int[,] array = MultiMatrix(array1, array2);

Console.WriteLine("Произведение массива 1 и 2 ");
PrintArray(array);


// int[] count = new int[4];


// for (int i = 0; i < array.GetLength(0); i++)
// {


//     for (int j = 0; j < array.GetLength(1); j++)
//     {


//         {
//             count[i] += array[i, j];
//         }
//     }
//     // Console.WriteLine($"сумма строки {i} равна {count[i]}");
// }


// FindCoulmnNumber(count);


