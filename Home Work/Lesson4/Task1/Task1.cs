for (int i = 0; i < 6; i++)
{
    int numberA = new Random().Next(0, 10);
    int numberB = new Random().Next(0, 10);
    Console.WriteLine("Число: " + numberA + " Степень: " + numberB);
    Console.WriteLine("Результат: " + Convert.ToInt32(Math.Pow(numberA, numberB)));
    Console.WriteLine();
}

