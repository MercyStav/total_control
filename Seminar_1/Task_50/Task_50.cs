int[,] mass = new int[7, 7];
Random ran = new Random();
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 7; j++)
    {
       mass[i, j] = ran.Next(1, 15);
       Console.Write("{0}\t", mass[i, j]);
    }
    Console.WriteLine();
}
Console.Write("Ищем значения в двумерном массиве, введи индекс строки для поиска:      ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи индекс столбца для поиска:      ");
int b = Convert.ToInt32(Console.ReadLine());
{
if (a > mass.GetLength(1) - 1 || b > mass.GetLength(0) - 1) 
{
    Console.WriteLine("По заданным значениям нет элемента в массиве");
}
else System.Console.WriteLine($"Нашли элемент {mass[a, b]}");
}