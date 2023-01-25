/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double PointDistance(double xA, double yA, double zA, double xB, double yB, double zB)
{
   double result = Math.Sqrt
(
    (xA - xB) * (xA - xB)
    + (yA - yB) * (yA - yB)
    + (zA - zB) * (zA - zB)
);
    return result;
}
Console.Write("Введите координату первой точки x: ");
double xA = double.Parse(Console.ReadLine());
Console.Write("Введите координату первой точки y: ");
double yA = double.Parse(Console.ReadLine());
Console.Write("Введите координату первой точки z: ");
double zA = double.Parse(Console.ReadLine());
Console.Write("Введите координату второй точки x: ");
double xB = double.Parse(Console.ReadLine());
Console.Write("Введите координату второй точки y: ");
double yB = double.Parse(Console.ReadLine());
Console.Write("Введите координату второй точки z: ");
double zB = double.Parse(Console.ReadLine());
Console.Write($"Расстояние между двумя точками составляет: {PointDistance(xA, yA, zA, xB, yB, zB):f}");