// Задача 1
Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine();

Console.WriteLine("Введите второе число");
string num2 = Console.ReadLine();

if (int.Parse(num1) > int.Parse(num2))
{
    Console.WriteLine("max num = " + num1);
}

else
{
    Console.WriteLine("max num = " + num2);
}
