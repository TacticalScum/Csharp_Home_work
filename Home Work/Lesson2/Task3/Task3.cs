Console.WriteLine("Введите число, обозначающее день недели");
string number = Console.ReadLine();
int day = int.Parse(number);

if (day % 6 == 0 || day % 7 == 0)
{
    Console.WriteLine("Этот день выходной");
}

else

{
    Console.WriteLine("Этот день рабочий");
}