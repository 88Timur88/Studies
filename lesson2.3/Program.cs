// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти (от 1 до 4) ---> ");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
if(!isParsedA)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
if(a > 0 && a < 5) 
{
    if(a == 1) Console.WriteLine("x > 0, y > 0");
    if(a == 2) Console.WriteLine("x < 0, y > 0");
    if(a == 3) Console.WriteLine("x < 0, y < 0");
    if(a == 4) Console.WriteLine("x > 0, y < 0");
}
else Console.WriteLine("Введенное число не соответветствует заданным требованиям");
