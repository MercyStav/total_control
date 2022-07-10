Console.Write("Программа определяет какое число из двух больше. Введи первое число:       ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число:      ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number1 > number2)
{
    Console.Write($"Наибольшее из двух чисел:        {number1}");
}
else
{
    Console.Write($"Наибольшее из двух чисел:        {number2}");
}
