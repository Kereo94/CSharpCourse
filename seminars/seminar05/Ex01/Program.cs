/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] CreateArray(int length = 4, int minValue = 100, int maxValue = 1000)
{
    int[] array = new int[length];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine("Наш массив: [" + string.Join(" ", array) + "]");
}
int[] array = CreateArray();
PrintArray(array);
int count = 0;

for (int z = 0; z < array.Length; z++)
if (array[z] % 2 == 0)
count++;

Console.WriteLine($"Количество четных чисел составляет {count}");