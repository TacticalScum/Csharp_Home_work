int lengthArr = new Random().Next(4, 11);
int[] array = new int[lengthArr];
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);

    if (i % 2 == 0)
    {
        result = result + array[i];
    }
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine("Сумма: " + result);