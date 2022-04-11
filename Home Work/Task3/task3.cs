// Задача 3
Console.WriteLine("Введите число");
string number = Console.ReadLine();

if (int.Parse(number) % 2 == 0)
{
    Console.WriteLine("Число " + number + " - чётное");
}

else
{
    Console.WriteLine("Число " + number + " - нечётное");
}
