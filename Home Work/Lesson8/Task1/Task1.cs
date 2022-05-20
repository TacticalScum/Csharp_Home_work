int line = new Random().Next(3, 10);
int column = new Random().Next(3, 10);
int[] tempArray = new int[column];
int[,] intArray = new int[line, column];

Console.WriteLine("Исходный массив:");
for (int i = 0; i < intArray.GetLength(0); i++)
{
    for (int j = 0; j < intArray.GetLength(1); j++)
    {
        intArray[i, j] = new Random().Next(1, 10);
        Console.Write(intArray[i, j] + "  ");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Отсортированный массив:");
for (int i = 0; i < intArray.GetLength(0); i++)
{
    for (int j = 0; j < intArray.GetLength(1); j++)
    {
        tempArray[j] = intArray[i, j];
    }
    sort(tempArray);
}

void sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                int stack = array[i];
                array[i] = array[j];
                array[j] = stack;
            }
        }

    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}