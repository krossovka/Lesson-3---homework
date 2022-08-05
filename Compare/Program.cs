Console.WriteLine("Нажмите Enter");
while (Console.ReadLine() != "exit")
{
    Console.WriteLine("Введите первое число:");
    int value3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int value4 = Convert.ToInt32(Console.ReadLine());
    if (value3 == value4)
    {
        Console.WriteLine("Числа равны");
    }
    if (value4 != value3)
    {
        Console.WriteLine("Числа не равны");
    }
    if (value3 > value4)
    {
        Console.WriteLine("Первое число больше");
    }
    if (value3 < value4)
    {
        Console.WriteLine("Второе число больше");

    }
    Console.WriteLine("Нажмите Enter");
}

