int line = new Random().Next(4, 7);
int column = new Random().Next(6, 10);
int[,] intArray = new int[line, column];
int[] lineSum = new int[line];

for (int i = 0; i < intArray.GetLength(0); i++)
{
    int x = 0;
    for (int j = 0; j < intArray.GetLength(1); j++)
    {
        intArray[i, j] = new Random().Next(1, 100);
        Console.Write(intArray[i, j] + "  ");
        x = x + intArray[i, j];
    }
    lineSum[i] = x;
    Console.WriteLine();
}
Console.WriteLine();

int min = lineSum[0];
int index = 0;
for (int i = 0; i < lineSum.Length; i++)
{
    if (min > lineSum[i])
    {
        min = lineSum[i];
        index = i;
    }
}
Console.WriteLine("Строка №" + (index + 1) + " с наименьшей суммой элементов: " + min);