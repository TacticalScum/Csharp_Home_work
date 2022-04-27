int lengthArr = new Random().Next(4, 11);
double[] array = new double[lengthArr];
double result = 0;

for (int i = 0; i < array.Length; i++)
{
    int x = new Random().Next(9, 16);
    array[i] = Math.Round(new Random().NextDouble() * x, 2);
}

Console.WriteLine("[{0}]", string.Join(", ", array));

double min = array[0];
double max = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];

    }
    if (array[i] > max)
    {
        max = array[i];
    }
    result = max - min;
}

Console.WriteLine("Разница между max и min = " + Math.Round(result, 2));