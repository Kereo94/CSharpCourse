﻿// Сложение двух рандомных чисел от 1 до 9
int numberA = new Random().Next(1, 10); // случайное число 1 2 3 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);