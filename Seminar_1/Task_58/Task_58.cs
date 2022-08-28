Console.Clear();
int[,] firstMartrix = new int[7, 7];
CreateMass(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteMass(firstMartrix);
int[,] twoMartrix = new int[7, 7];
CreateMass(twoMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteMass(twoMartrix);
int[,] resultMatrix = new int[7,7];
MultiplyMatrix(firstMartrix, twoMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteMass(resultMatrix);
void MultiplyMatrix(int[,] firstMartrix, int[,] twoMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * twoMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
void CreateMass(int[,] Mass)
{
  for (int i = 0; i < Mass.GetLength(0); i++)
  {
    for (int j = 0; j < Mass.GetLength(1); j++)
    {
      Mass[i, j] = new Random().Next(1, 15);
    }
  }
}
void WriteMass (int[,] Mass)
{
  for (int i = 0; i < Mass.GetLength(0); i++)
  {
    for (int j = 0; j < Mass.GetLength(1); j++)
    {
      Console.Write(Mass[i,j] + " ");
    }
    Console.WriteLine();
  }
}