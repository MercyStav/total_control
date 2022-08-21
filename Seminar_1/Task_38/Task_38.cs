double[] mass = { 21.2800, 13.09, 5.55, 55.123, 23.234234 };
double max = 0;
double min = 100;
for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > max) max = mass[i];
        if (mass[i] < min) min = mass[i];
    }
Console.WriteLine($"Разница между максимальными и минимальными значениями массива составляет: {max - min}");