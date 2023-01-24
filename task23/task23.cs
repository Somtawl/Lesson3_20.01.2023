Console.WriteLine("Введите число не мненьше 1");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write("{0} ",Math.Pow(i,3));
    }
}
else
{
    Console.WriteLine("Неверное число");
}