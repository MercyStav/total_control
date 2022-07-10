Console.Write("Программа показывает все положительные чётные числа, до того числа, которое вы введёте:       ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 0) {
    if (number % 2 == 0) { Console.Write($"{number} "); }
    number = number - 1;
}
