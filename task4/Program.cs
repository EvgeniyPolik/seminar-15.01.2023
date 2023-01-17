Console.Write("Введите координаты точки А, через пробел в формате x y для 2D и x y z для 3D: ");
int[] pointA = (Console.ReadLine() ?? "").Split(' ').Select(int.Parse).ToArray();
Console.Write("Введите координаты точки B, через пробел в формате x y для 2D и x y z для 3D: ");
int[] pointB = (Console.ReadLine() ?? "").Split(' ').Select(int.Parse).ToArray();
if ((pointA.Length == pointA.Length) && (pointA.Length > 1) && (pointB.Length > 1) && (pointA.Length <= 3
) && (pointB.Length <= 3))
    if (pointA.Length == 2)
        Console.WriteLine($"Расстояние между точками: {(int)Math.Sqrt(((pointA[0] - pointB[0]) * (pointA[0] - pointB[0])) + ((pointA[1] - pointB[1]) * (pointA[1] - pointB[1])))}");
    else
        Console.WriteLine($"Расстояние между точками: {(int)Math.Sqrt(((pointA[0] - pointB[0]) * (pointA[0] - pointB[0])) + ((pointA[1] - pointB[1]) * (pointA[1] - pointB[1])) + ((pointA[2] - pointB[2]) * (pointA[2] - pointB[2])))}");
else
    Console.WriteLine("Неверный ввод");