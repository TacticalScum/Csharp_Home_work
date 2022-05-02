int arrSize = 1;
int[] array = new int[arrSize];
string num;
int counter = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число или q для выхода");
    num = Console.ReadLine();

    if (num == ("q"))
    {
        break;
    }

    else
    {
        arrSize++;

        array[i] = Convert.ToInt32(num);

        if (i == array.Length - 1)
        {
            Array.Resize<int>(ref array, arrSize);
        }
    }

    if (array[i] > 0)
    {
        counter++;
    }
}

Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine("Чисел больше нуля: " + counter);