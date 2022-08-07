Console.Write("Введи число A:      ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число B:      ");
int B = Convert.ToInt32(Console.ReadLine());
int C = A;
for (int i = 2; i <= B; i++)
{
    A = A * C;
}
Console.Write($"{A}");