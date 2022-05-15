int line = new Random().Next(3, 10);
int column = new Random().Next(3, 10);
double arithmeticMean;

int[,] intArray = new int[line, column];

for (int i = 0; i < intArray.GetLength(0); i++)
{
    for (int j = 0; j < intArray.GetLength(1); j++)
    {
        intArray[i, j] = new Random().Next(1, 100);
        Console.Write(intArray[i, j] + "  ");
    }
    Console.WriteLine();
}

for (int i = 0; i < intArray.GetLength(1); i++)
{
    arithmeticMean = 0;
    for (int j = 0; j < intArray.GetLength(0); j++)
    {
        arithmeticMean = arithmeticMean + intArray[j, i];
    }
    Console.WriteLine("Среднее арифметическое " + (i + 1) + " столбца равна: " + (arithmeticMean / line).ToString("F"));
}