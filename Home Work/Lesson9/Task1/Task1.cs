Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write("M = " + numberM + "; N = " + numberN + " -> ");

for (int i = numberM; i <= numberN; i++)
{
    if (i == numberN)
    {
        Console.Write(i);
    }
    else
    {
        Console.Write(i + ", ");
    }
}