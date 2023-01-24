Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine()); //Ждем int на случай ввода строки а не числа
string NumString = Convert.ToString(num);
if (NumString.Length == 5)
{
    if (NumString[0] == NumString[4] && NumString[1] == NumString[3])
    {
        Console.WriteLine("Число {0} палиндромно",num);
    }
    else
    {
        Console.WriteLine("Число {0} не палиндромно",num);
    }
}
else
{
    Console.WriteLine("Неверное сичло");
}