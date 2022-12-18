/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите целое число от 2: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 1;
int index = 1;           
if (number < 2)
	{
		Console.WriteLine("Введено некорректное число. Введите корректиное значиение");
	}
while(true)
{
	if (a % 2 == 0)
	{
		Console.WriteLine(a);
		index = index + 2;
	}
	if (index >= number)
	{
		break;
	}
a ++;
}
