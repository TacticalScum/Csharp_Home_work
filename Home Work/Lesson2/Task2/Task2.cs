Console.WriteLine("Введите число");
string number = Console.ReadLine();

if(int.Parse(number) < 100){
    Console.WriteLine("Третьего числа нету");
}

else{
char[] array = number.ToCharArray();
Console.WriteLine("Третье число: " + array[2]);
}