Console.WriteLine("Введите координату b1");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату k1");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату b2");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату k2");
double k2 = double.Parse(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}

else
{
    double koordX = (b2 - b1) / (k1 - k2);
    double koordY = k1 * koordX + b1;

    Console.WriteLine("Координаты точки пересечения:  " + Math.Round(koordX, 3) + ", " + Math.Round(koordY, 3));
}