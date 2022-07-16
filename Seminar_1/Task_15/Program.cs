Console.WriteLine("Введите число дня недели.");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number > 5 && number < 8)
{
    Console.WriteLine("Выходной");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine("Рабочий");
}
else 
{
    Console.WriteLine("Число вне диапазона недели");
};