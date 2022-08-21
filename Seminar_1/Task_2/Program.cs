Console.Write("Программа определяет какое число из трёх больше. Введи первое число:       ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число:      ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье число:      ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number1 > number2) { max = number1; } else {max = number2;}
if (max > number3) { max = max; } else {max = number3;}
{
    Console.Write($"Наибольшее из трёх чисел:        {max}");
}