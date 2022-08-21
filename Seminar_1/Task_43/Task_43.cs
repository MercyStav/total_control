// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Введи k1:      ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи k2:      ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи b1:      ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи b2:      ");
int b2 = Convert.ToInt32(Console.ReadLine());
int x = (b2 - b1) / (k1 - k2);
int y = k1 * x + b1;
Console.Write($"Точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2:({x};{y})");
