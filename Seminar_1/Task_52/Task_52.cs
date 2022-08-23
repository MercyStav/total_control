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
for (int j = 0; j < mass.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        sum += mass[i, j];
    }
    double average = sum / mass.GetLength(0);
    Console.WriteLine($"Среднее арифметическое столбца {j} = {average:F2}");
}