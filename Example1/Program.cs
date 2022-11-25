// Напишите программу, которая принимает на вход пятизначное 
//  число и проверяет, является ли оно палиндромом.
//  14212 -> нет
//  12821 -> да
//  23432 -> да

Console.WriteLine("Введите пятизначное число:");
string arr = Console.ReadLine();

if (arr.Length == 5)
{
if (arr[0] == arr[4]&& arr[1] == arr[3])
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}
}
else
{
Console.WriteLine("Ошибка. Введите пятизначное число");
}

