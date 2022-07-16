Console.WriteLine("Введите трехзначное число.");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = number.ToString ();
if (numberS.Length > 2)
{
    Console.WriteLine(numberS[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
};