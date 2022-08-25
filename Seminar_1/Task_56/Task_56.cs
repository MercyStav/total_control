int[,] mass = new int[9, 9];
CreateArray(mass);
WriteArray(mass);
int SumMin = 0;
int sumLine = ElementSum(mass, 0);
for (int i = 1; i < mass.GetLength(0); i++)
{
  int tempSumLine = ElementSum(mass, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    SumMin = i;
  }
}
Console.WriteLine($"\nМеньше всего элементов в строке {SumMin}, насчитали элементов {sumLine} ");
int ElementSum(int[,] mass, int i)
{
  int sumLine = mass[i,0];
  for (int j = 1; j < mass.GetLength(1); j++)
  {
    sumLine += mass[i,j];
  }
  return sumLine;
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
      Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
  }
}