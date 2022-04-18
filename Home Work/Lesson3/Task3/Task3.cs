Console.WriteLine("Введите число N");
string num = Console.ReadLine();
int number = int.Parse(num);

int[] arrFiller = new int[number];
for (int i = 1; i < arrFiller.Length; i++)
{
    arrFiller[0] = 1;
    arrFiller[i] = arrFiller[i - 1] + 1;
}

Console.Write("Исходное число " + number + ": ");

for (int i = 0; i < arrFiller.Length; i++)
{
    if (i == arrFiller.Length - 1)
    {
        Console.Write(Math.Pow(arrFiller[i], 3));
    }
    else
    {
        Console.Write(Math.Pow(arrFiller[i], 3) + ", ");
    }
}