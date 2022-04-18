Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();

//int number = int.Parse(num);
char[] arr = number.ToCharArray();

if(arr[0] == arr[4] && arr[1] == arr [3]){
Console.WriteLine("Число " + number + " - полиндром");
}
else
{
Console.WriteLine("Число " + number + " - не полиндром");
}
