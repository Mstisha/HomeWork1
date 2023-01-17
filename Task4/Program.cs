Console.WriteLine("Введите Ваше число:");
string numbersStr1 = Console.ReadLine();
int a = Convert.ToInt32(numbersStr1);

Console.WriteLine("Введите Ваше второе число:");
string numbersStr2 = Console.ReadLine();
int b = Convert.ToInt32(numbersStr2);

Console.WriteLine("Введите Ваше третье число:");
string numbersStr3 = Console.ReadLine();
int c = Convert.ToInt32(numbersStr3);

if (a > b & a > c)
{
    Console.WriteLine(a);
}
else if (b > a & b > c)
{
    Console.WriteLine(b);
}
else if (c > a & c > b)
{
    Console.WriteLine(c);
}
else
{
    Console.WriteLine("Числа равны!");
}