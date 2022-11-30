Console.Write("Введите целое число:");
int n = Convert.ToInt32(Console.ReadLine ());
int a = 1;
int index = 1;           
while (true)
{
	if (a % 2 == 0)
	{
		Console.WriteLine(a);
		index = index + 2;
	}
	if (index >= n)
	{
		break;
	}
a = a + 1;
}
