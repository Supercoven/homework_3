Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
  
void Palyndrome()
{
     string forCheck = num.ToString(); // преобразуем в строку для проверки количества символов

    int firstDigit = num /10000; // первая цифра с начала
    int firstSecondDigit = num /1000; // первая и вторая цифра с начала
    int secondDigit = firstSecondDigit % 10; // вторая цифра с начала

    int lastDigit = num % 10; // последняя цифра с конца
    int twoLastDigits = num % 100;
    int preLastDigit = twoLastDigits / 10; // вторая цифра с конца

if (forCheck.Length != 5)
{
    Console.WriteLine("Число не пятизначное");
}
else if (firstDigit == lastDigit & secondDigit == preLastDigit)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
}

Palyndrome();