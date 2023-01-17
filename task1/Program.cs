Console.Write("Введите номер дня недели: ");
var numberDay = int.Parse(Console.ReadLine() ?? "");
if (numberDay > 0 && numberDay <= 7)
    if (numberDay == 6 || numberDay == 7)
        Console.WriteLine("Выбран выходной день");
    else
        Console.WriteLine("Выбран будний день");
else
     Console.WriteLine("Не верный ввод");