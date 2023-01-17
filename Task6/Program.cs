Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if (number % 2 == 0)
{
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("НЕТ!");
}