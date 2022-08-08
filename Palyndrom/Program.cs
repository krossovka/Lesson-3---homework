int n = Convert.ToInt32(Console.ReadLine());
Console.Write(n % 10);

while ((n /= 10) != 0)
	Console.Write(n % 10);