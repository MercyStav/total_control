Console.WriteLine("Введите трехзначное число.");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    string numberS = number.ToString ();
    Console.WriteLine(numberS[1]);
}
else {
    Console.WriteLine("Введено не трёхзначное число.");
}
