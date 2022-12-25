/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double PointDistance(double positionfirstx, double positionfirsty, double positionfirstz, double positionsecondx, double positionsecondy, double positionsecondz)
{
   double result = Math.Sqrt
(
    (positionfirstx - positionsecondx) * (positionfirstx - positionsecondx)
    + (positionfirsty - positionsecondy) * (positionfirsty - positionsecondy)
    + (positionfirstz - positionsecondz) * (positionfirstz - positionsecondz)
);
    return result;
}
Console.Write("Введите координату первой точки x: ");
double positionfirstx = double.Parse(Console.ReadLine());
Console.Write("Введите координату первой точки y: ");
double positionfirsty = double.Parse(Console.ReadLine());
Console.Write("Введите координату первой точки z: ");
double positionfirstz = double.Parse(Console.ReadLine());
Console.Write("Введите координату второй точки x: ");
double positionsecondx = double.Parse(Console.ReadLine());
Console.Write("Введите координату второй точки y: ");
double positionsecondy = double.Parse(Console.ReadLine());
Console.Write("Введите координату второй точки z: ");
double positionsecondz = double.Parse(Console.ReadLine());
Console.Write($"Расстояние между двумя точками составляет: {PointDistance(positionfirstx, positionfirsty, positionfirstz, positionsecondx, positionsecondy, positionsecondz):f}");