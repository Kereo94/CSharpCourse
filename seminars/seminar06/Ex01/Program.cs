/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.Write("Введите количество элементов массива: ");
int elememtsCount = int.Parse(Console.ReadLine());
int[] array = new int[elememtsCount];
int positiveNumber = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.Write("Вывод массива: [ ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
    if (array[i] > 0)
    {
        positiveNumber++;
    }
}
Console.WriteLine("]");
Console.Write("Количество положительных чисел = " + positiveNumber);
