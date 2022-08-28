int[,] newMass = new int[7, 7];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= newMass.GetLength(0) * newMass.GetLength(1))
{
  newMass[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < newMass.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= newMass.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > newMass.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteMass(newMass);

void WriteMass (int[,] mass)
{
  for (int i = 0; i < mass.GetLength(0); i++)
  {
    for (int j = 0; j < mass.GetLength(1); j++)
    {
      if (mass[i,j] / 10 <= 0)
      Console.Write($" {mass[i,j]} ");

      else Console.Write($"{mass[i,j]} ");
    }
    Console.WriteLine();
  }
}