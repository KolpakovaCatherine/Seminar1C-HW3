/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int Digit = Convert.ToInt32(Console.ReadLine());

while (Digit < 10000 || Digit > 99999)
{
    Console.WriteLine("Это не пятизначное число. Введите пятизначное число: ");
    Digit = Convert.ToInt32(Console.ReadLine());
}

int firstnumber = Digit / 10000;
int secondnumer = Digit / 1000 % 10;
int fourthnumer = Digit / 10 % 10;
int fifthnumer = Digit % 10;

//Console.WriteLine ($"{firstnumber} и {secondnumer} и {fourthnumer} и {fifthnumer}");

if (firstnumber == fifthnumer)
{
    if (secondnumer == fourthnumer)
    {
        Console.WriteLine("Число является палиндромом");
    }
}
else
{
    Console.WriteLine("Число не является палиндромом");
}