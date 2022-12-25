/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int index  = 0;
int result = 0;

while(index < number)
{
    index++;
    result = index * index * index;
    Console.Write($"{result} ");
}
