﻿// Задача 2
Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine();

Console.WriteLine("Введите второе число");
string num2 = Console.ReadLine();

Console.WriteLine("Введите третье число");
string num3 = Console.ReadLine();

if (int.Parse(num1) > int.Parse(num2))
{
    if (int.Parse(num1) > int.Parse(num3))
    {
        Console.WriteLine("max num = " + num1);
    }
}

else if (int.Parse(num2) > int.Parse(num3))
{
    Console.WriteLine("max num = " + num2);
}

else
{
    Console.WriteLine("max num = " + num3);
}
