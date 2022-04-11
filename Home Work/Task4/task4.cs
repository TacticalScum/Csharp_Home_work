// Задача 4
Console.WriteLine("Введите число");
string number = Console.ReadLine();

int evenNumbers = int.Parse(number);
if (evenNumbers < 2)
{
    Console.WriteLine("Четные числа: - ");
}

else
{
    Console.Write("Четные числа: ");
    while (evenNumbers > 1)
    {
        
        if (evenNumbers % 2 == 0)
        {
            Console.Write(evenNumbers + ", ");
        }
        evenNumbers--;
    }
}