/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на чётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateArray(int length = 4, int minValue = -100, int maxValue = 100)
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

int sum = 0;

for (int z = 1; z < array.Length; z+=2)
    sum = sum + array[z];
    Console.WriteLine($"Cумма элементов на чётных позициях = {sum}");