Console.WriteLine("Введите номер четверти: ");
var quarteNumber = Console.ReadLine() ?? "";
switch (quarteNumber)
    {
        case "1":
            Console.Write("Доступные координаты: X > 0, Y > 0");
            break;
        case "2":
            Console.Write("Доступные координаты: X < 0, Y > 0");
            break;
        case "3":
            Console.Write("Доступные координаты: X < 0, Y < 0");
            break;
        case "4":
            Console.Write("Доступные координаты: X > 0, Y < 0");
            break;
        default:
            Console.Write("Неверный ввод");
            break;
    }