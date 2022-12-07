/*Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координаты X первой точки");
int x1 = Console.ReadLine();

Console.WriteLine("Введите координаты Y первой точки");
int y1 = Console.ReadLine();

Console.WriteLine("Введите координаты X второй точки");
int x2 = Console.ReadLine();

Console.WriteLine("Введите координаты Y второй точки");
int y2 = Console.ReadLine();

double DistXY (int x1, int y1, int x2, int y2)
{
    double result =0;
    result = Math.Sqrt((Math.Pow(x1 - x2 ),2) + (Math.Pow(y1 - y2 ),2));

    return result;
}
