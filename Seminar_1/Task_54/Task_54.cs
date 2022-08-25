int[,] mass = new int[10, 10];
Console.WriteLine($"\nНеотсортированный массив: ");
CreateArray(mass);
WriteArray(mass);
Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(mass);
WriteArray(mass);
void OrderArrayLines(int[,] mass)
{
  for (int i = 0; i < mass.GetLength(0); i++)
  {
    for (int j = 0; j < mass.GetLength(1); j++)
    {
      for (int k = 0; k < mass.GetLength(1) - 1; k++)
      {
        if (mass[i, k] < mass[i, k + 1])
        {
          int temp = mass[i, k + 1];
          mass[i, k + 1] = mass[i, k];
          mass[i, k] = temp;
        }
      }
    }
  }
}
void CreateArray(int[,] mass)
{
  for (int i = 0; i < mass.GetLength(0); i++)
  {
    for (int j = 0; j < mass.GetLength(1); j++)
    {
      mass[i, j] = new Random().Next(1, 15);
    }
  }
}
void WriteArray(int[,] mass)
{
  for (int i = 0; i < mass.GetLength(0); i++)
  {
    for (int j = 0; j < mass.GetLength(1); j++)
    {
      Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
  }
}