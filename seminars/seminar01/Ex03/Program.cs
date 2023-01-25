/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите целое число от 2: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= number)
{
	if (number < 2)
	{
		Console.WriteLine("Введено некорректное число. Введите корректиное значение");
	}
	if (i % 2 == 0)
	{
		Console.Write(i + " ");
	}
	i++;
}