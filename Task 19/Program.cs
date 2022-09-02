// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
string forCheck = num.ToString();

if (forCheck.Length == 5);
{
    int firstDigit = num /10000; // первая цифра с начала
    int firstSecondDigit = num /1000; // первая и вторая цифра с начала
    int secondDigit = firstSecondDigit % 10; // вторая цифра с начала

    int lastDigit = num % 10; // последняя цифра с конца
    int twoLastDigits = num % 100;
    int preLastDigit = twoLastDigits / 10; // вторая цифра с конца

}
    
