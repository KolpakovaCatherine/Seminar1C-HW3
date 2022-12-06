/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;

if (number <= 0)
{
    while (count >= number)
    {
        if (count > number)
            Console.Write(count * count * count + ", ");
        else
        {
            Console.WriteLine(count * count * count);
        }
        count--;
    }
}

else
{

    while (count <= number)
    {
        if (count < number)
            Console.Write(count * count * count + ", ");
        else
        {
            Console.WriteLine(count * count * count);
        }
        count++;
    }
}