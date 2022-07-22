Console.Write("Введите число    ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Таблица кубов чисел:");
while (i <= n){
    Console.WriteLine($"| {i} | {i * i * i}|");
    i++ ;
};