Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int summ = 0;

Console.Write("M = " + numberM + "; N = " + numberN + " -> ");

for (int i = numberM; i <= numberN; i++)
{
summ = summ + i;
}
Console.Write(summ);