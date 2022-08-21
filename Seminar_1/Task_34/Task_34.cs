int[] array = new int [40];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,999);
    Console.Write($"{array[i]} ");
}
int res = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) res++;
}
Console.WriteLine($"Колличество чётных элементов в массиве: {res}");