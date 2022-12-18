
/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA == numberB)
{
    Console.Write($"{numberA} и {numberB} равны");
}
else if(numberA > numberB)
{
    Console.WriteLine($"Максимальное число {numberA}");
    Console.Write($"Минимальное число {numberB}");
}
else
{
    Console.WriteLine($"Максимальное число {numberB}");
    Console.Write($"Минимальное число {numberA}");
}