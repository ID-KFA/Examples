// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координату Х ");
int x = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координату Y ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0) Console.WriteLine("Ваша точка в первой четверти"); 
if (x<0 && y>0) Console.WriteLine("Ваша точка во второй четверти");    
if (x<0 && y<0) Console.WriteLine("Ваша точка в третьей четверти");   
if (x>0 && y<0) Console.WriteLine("Ваша точка в четвертой четверти");     