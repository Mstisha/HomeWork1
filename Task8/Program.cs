Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

for (int i = 1; i < number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ",");
    }
}