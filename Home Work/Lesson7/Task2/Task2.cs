int line = new Random().Next(3, 10);
int column = new Random().Next(3, 10);

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

Console.WriteLine("Введите строку");
int userLine = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец");
int userColumn = Convert.ToInt32(Console.ReadLine());

if (userLine > line || userLine < 1 || userColumn > column || userColumn < 1)
{
    Console.WriteLine("Такого значения нет");
}
else
{
    Console.WriteLine("Число в ячейке " + userLine + ", " + userColumn + ": " + intArray[userLine - 1, userColumn - 1]);
}