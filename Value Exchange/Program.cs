Console.WriteLine("Введите первое число...");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число...");
int b = Convert.ToInt32(Console.ReadLine()); ;
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.ReadKey();


