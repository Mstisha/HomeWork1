Console.WriteLine("Введите первое число:");
string numbersStr1 = Console.ReadLine();
int a = Convert.ToInt32(numbersStr1);

Console.WriteLine("Введите второе число:");
string numbersStr2 = Console.ReadLine();
int b = Convert.ToInt32(numbersStr2);
int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.WriteLine($"Максимальное и наибольшее число {max}");