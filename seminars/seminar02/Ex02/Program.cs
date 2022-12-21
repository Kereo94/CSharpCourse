/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int thirdDigit = Convert.ToInt32(Console.ReadLine());
int digitA = 0;

if (thirdDigit < 100)
{
    Console.Write("Третьей цифры нет");
}
if (thirdDigit > 100)
{
    while (thirdDigit >= 1000)
    {
        thirdDigit = thirdDigit / 10;
    }
    digitA = thirdDigit % 10;

    Console.Write($"Третья цифра числа - {digitA}");
}