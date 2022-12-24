//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
string a = Console.ReadLine();

while (a.Length != 5){
    Console.Write("Ошибка ");
    Console.Write("Введите пятизначное число: ");
    a = Console.ReadLine();
}

if (a[0] == a[4] && a[1] == a[3])
    Console.WriteLine("Число палиндром");
else
    Console.WriteLine("Число не палиндром");