double[,] a = new double[4, 4];

Random random = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = random.NextDouble() * 50;
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}