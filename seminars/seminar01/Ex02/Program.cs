/* Напишите программу, которая на вход принимает число и выдаёт, является ли число целым или дробным.
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine ());

if(a % 2 == 0)
{
    Console.WriteLine("Число целое");
}
else
{
    Console.WriteLine("Число дробное");
}