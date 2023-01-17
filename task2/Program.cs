Console.Write("Введите первое число: ");
var a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
var b = int.Parse(Console.ReadLine() ?? "");
if (a == b*b)
    Console.Write($"Число {a} является квадратом числа {b}");
else
    Console.Write($"Число {a} не является квадратом числа {b}");