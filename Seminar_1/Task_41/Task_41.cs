Console.Write("Программа определяет колличество введённых чисел больше 0, введи сколько ты хочешь проверить чисел:       ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int [M];
for (int i = 0; i < M; i++)
{
    Console.Write("Вводи число и жми enter:      ");
    int j = Convert.ToInt32(Console.ReadLine());
    array[i] = j;
}
int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) res++;
};
Console.Write($"Ты ввёл {res} чисел больше 0");