/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;

while(number > 0)
{
    int num = number % 10;
    number = number / 10;
    sum = sum + num;
}
Console.Write("Сумма цифр числа равна: " + sum);