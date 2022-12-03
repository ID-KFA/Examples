// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти ");
int x = Convert.ToInt32(Console.ReadLine());
if (x>4 || x<1) Console.WriteLine("Такой четверти нет");


if (x==1) Console.WriteLine("В этой четверти X>0 и Y>0"); 

if (x==2) Console.WriteLine("В этой четверти X<0 и Y>0"); 
if (x==3) Console.WriteLine("В этой четверти X<0 и Y<0");
if (x==4) Console.WriteLine("В этой четверти X>0 и Y<0");
