int a = 2, b = 3, c = 7;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);