// ..Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void PrintArray(int[, ,] array)
{

    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}");
                 Console.Write($"({i},{j},{k}) ");
            }
           Console.WriteLine(); 
        }
        //Console.WriteLine();
    }

}

int[,,] array =new int[2,2,2] {
    {{66,27},
    {25,90}},
    {{34,26},
    {41,55}}};
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



// int[,] FillArray(int col, int row)
// {
//     int[,] array = new int[col, row];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;



// int[,] MultiMatrix(int[,] array1, int[,] array2)
// {
//     int[,] array = new int[2, 2];

//     array[0, 0] = array1[0, 0] * array2[0, 0] + array1[0, 1] * array2[1, 0];
//     array[0, 1] = array1[0, 0] * array2[0, 1] + array1[0, 1] * array2[1, 1];
//     array[1, 0] = array1[1, 0] * array2[0, 0] + array1[1, 1] * array2[1, 0];
//     array[1, 1] = array1[1, 0] * array2[0, 1] + array1[1, 1] * array2[1, 1];

//     return array;

// }

// int[,] array1 = FillArray(2, 2);
// int[,] array2 = FillArray(2, 2);

Console.WriteLine("Задан массив ");
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


