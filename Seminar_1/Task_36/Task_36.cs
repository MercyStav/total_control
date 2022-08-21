int[] array = new int [10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write($"{array[i]} ");
}
int res = 0;
for (int j = 1 ; j < array.Length; j = j + 2)
{
    res = res + array[j];
}
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях массива: {res}");