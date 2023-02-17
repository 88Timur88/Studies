// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Write("Введите последнее число k1:   ");
bool isParsedk1 = int.TryParse(Console.ReadLine(), out int k1);
if(!isParsedk1)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
Console.Write("Введите последнее число b1:   ");
bool isParsedb1 = int.TryParse(Console.ReadLine(), out int b1);
if(!isParsedb1)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
Console.Write("Введите последнее число k2:   ");
bool isParsedk2 = int.TryParse(Console.ReadLine(), out int k2);
if(!isParsedk2)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
Console.Write("Введите последнее число b2:   ");
bool isParsedb2 = int.TryParse(Console.ReadLine(), out int b2);
if(!isParsedb2)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

int x = -(b1 - b2) / (k1 - k2);
int y = k1 * x + b1;

Console.WriteLine($"Пересечение в точке {x};{y}");