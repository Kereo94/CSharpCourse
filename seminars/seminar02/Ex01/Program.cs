/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GetSecondDigit(int number)
{
    int digit = number / 10;
    int result = digit % 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int score = GetSecondDigit(number);

if(number < 100 || number > 1000)
{
    Console.Write("Введено некорректное число");
}
else
{
    Console.Write($"Вторая цифра {number} - {score}");
}