int lengthArr = new Random().Next(4, 11);
int[] array = new int[lengthArr];
int chetNum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
    
    if (array[i] % 2 == 0)
    {
        chetNum++;
    }
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine("Четных чисел: " + chetNum);
