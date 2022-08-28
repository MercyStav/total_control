Console.WriteLine( "\nРисуем трёхмерный массив из неповторяющихся двузначных чисел и выводим его построчно с индексами");
int[,,] mass3D = new int[4, 4, 2];
Createmass(mass3D);
WriteMass(mass3D);
void WriteMass (int[,,] mass3D)
{
  for (int i = 0; i < mass3D.GetLength(0); i++)
  {
    for (int j = 0; j < mass3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < mass3D.GetLength(2); k++)
      {
        Console.Write( $"Число({k})={mass3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
void Createmass(int[,,] mass3D)
{
  int[] temp = new int[mass3D.GetLength(0) * mass3D.GetLength(1) * mass3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 99);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 99);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < mass3D.GetLength(0); x++)
  {
    for (int y = 0; y < mass3D.GetLength(1); y++)
    {
      for (int z = 0; z < mass3D.GetLength(2); z++)
      {
        mass3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}