int[,] array = new int[5, 5];
int num = 1;
int x = 0;
//int y =0;
fillArray(array, x, x);
printArray(array);



void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "     ");
        }
        Console.WriteLine();
    }
}

int[,] fillArray(int[,] array, int x, int y)
{


    for (int j = y; j < array.GetLength(1); j++)
    {
        if (array[x, j] == 0)
        {

            array[x, j] = num++;
        }
    }


    for (int i = x; i < array.GetLength(0); i++)
    {

        for (int j = array.GetLength(1) - 1-x; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = num++;
            }
        }
    }



        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (array[array.GetLength(0) - 1-x, j] == 0)
            {
                array[array.GetLength(0) - 1-x, j] = num++;
            }
        }
    

    for (int i = array.GetLength(0) - 1; i >= 0; i--)
    {
        if (array[i, y] == 0)
        {
            array[i, y] = num++;
            x = i;
        }
    }
Console.WriteLine(x);
    if (array[x, x] == 0)
    {
        fillArray(array, x, x);

    }
    return array;
}



