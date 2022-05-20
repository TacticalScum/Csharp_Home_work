int[,,] array = new int[3, 5, 5];
int num = 10;
fillArray(array);
printArray(array);


int[,,] fillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = num++;
            }
        }
    }
    return array;
}

void printArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("(" + i + ", " + j + ", " + k + ")" + array[i, j, k] + "  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
