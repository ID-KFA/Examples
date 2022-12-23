// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int nums =0;

int Sum(int M, int N)

{

    if (N==M) return M;
    else return N + Sum(M, N-1);
    

}
Console.WriteLine("Введите M ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(x,y));