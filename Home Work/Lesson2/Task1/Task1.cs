int number = new Random().Next(99,1000);
Console.WriteLine (number);

int firstNumber = number/100;
int secondNumber = number%10;

Console.WriteLine (firstNumber + "" + secondNumber);