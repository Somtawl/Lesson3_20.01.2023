Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int numbers = (int)Math.Log10(num) + 1;
if (numbers == 5)
{
    int num1 = num / 10000 % 10;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;
    if (num1 == num5 && num2 == num4)
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