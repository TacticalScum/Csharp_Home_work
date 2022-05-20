int line1 = new Random().Next(3, 10);
int column1 = new Random().Next(4, 8);
int[,] intArray1 = new int[line1, column1];

int line2 = new Random().Next(4, 8);
int column2 = new Random().Next(3, 10);
int[,] intArray2 = new int[line2, column2];

fillArray(intArray1);
Console.WriteLine();
fillArray(intArray2);

if (column1 != line2)
{
    Console.WriteLine("Число столбцов матрицы 1 больше строк матрицы 2. \nМатрицы перемножить нельзя.");
}
else
{
    printArray(intArray1);
    printArray(intArray2);
    Console.WriteLine();
    int[,] matrixDigit = new int[line1, column2];
    for (int i = 0; i < matrixDigit.GetLength(0); i++)
    {
        for (int j = 0; j < matrixDigit.GetLength(1); j++)
        {
            for (int k = 0; k < intArray1.GetLength(1); k++)
            {
                matrixDigit[i, j] += intArray1[i, k] * intArray2[k, j];
            }
        }
    }

    printArray(matrixDigit);
}

int[,] fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}