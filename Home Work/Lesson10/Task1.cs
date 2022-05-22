int numbersSequenceRightBound = 0;

Console.WriteLine("Введите число: ");
numbersSequenceRightBound = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество групп для разбиения: {CalculateGroupsNumber(numbersSequenceRightBound)}");
for (int i = 1; i <= CalculateGroupsNumber(numbersSequenceRightBound); i++)
{
    Console.WriteLine($"{i}-я группа: [{string.Join(", ", GetNextGroup(i, CalculateGroupsNumber(numbersSequenceRightBound), numbersSequenceRightBound))}]");
}

int CalculateGroupsNumber(int numbersSequenceRightBound)
{
    int groupsNumber = (int)Math.Ceiling(Math.Log2(numbersSequenceRightBound));

    if ((int)Math.Pow(2, groupsNumber) == numbersSequenceRightBound)
        groupsNumber++;

    return groupsNumber;
}

int[] GetNextGroup(int groupNumber, int groupsQuantity, int numbersSequenceRightBound)
{
    if (groupNumber != groupsQuantity)
        return Enumerable.Range((int)Math.Pow(2, groupNumber - 1), (int)Math.Pow(2, groupNumber) - (int)Math.Pow(2, groupNumber - 1)).ToArray();
    else
        return Enumerable.Range((int)Math.Pow(2, groupNumber - 1), numbersSequenceRightBound - (int)Math.Pow(2, groupNumber - 1) + 1).ToArray();
}