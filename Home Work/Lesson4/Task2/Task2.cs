int number = new Random().Next(0, 10000);
int result = 0;
Console.WriteLine("Число: " + number);
while (true)
{
    int singleNum = number % 10;
    result = result + singleNum;
    number = number / 10;
    if (number == 0)
    {
        break;
    }
}
Console.WriteLine("Сумма чисел: " + result);