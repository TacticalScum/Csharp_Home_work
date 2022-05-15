int line = new Random().Next(3, 10);
int column = new Random().Next(3, 10);

Double[,] doubleArray = new double[line, column];

for (int i = 0; i < doubleArray.GetLength(0); i++)
{
    for (int j = 0; j < doubleArray.GetLength(1); j++)
    {
        doubleArray[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
        Console.Write(doubleArray[i, j] + "  ");
    }

    Console.WriteLine();
}
