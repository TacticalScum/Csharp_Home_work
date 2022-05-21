Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int k = 0;
k = akkermanFunction(m, n);
Console.WriteLine("m = " + m + "; n = " + n + " -> A(m,n) = " + k);


static int akkermanFunction(int m, int n)
{
    if (m == 0) { return n + 1; }
    if (m > 0 && n == 0) { return akkermanFunction(m - 1, 1); }
    if (m > 0 && n > 0) { return akkermanFunction(m - 1, akkermanFunction(m, n - 1)); }
    return akkermanFunction(m, n);
}