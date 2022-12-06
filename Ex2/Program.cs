/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int xa = ReadInt("Введите координаты X точки А: ");
int ya = ReadInt("Введите координаты Y точки А: ");
int za = ReadInt("Введите координаты Z точки А: ");

int xb = ReadInt("Введите координаты Х точки B: ");
int yb = ReadInt("Введите координаты Y точки B: ");
int zb = ReadInt("Введите координаты Z точки B: ");

int katetX = xa - xb;
int katetY = ya - yb;
int katetZ = za - zb;

double result = Math.Round(Math.Sqrt(katetX * katetX + katetY * katetY + katetZ * katetZ), 2);
Console.WriteLine(result);



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}