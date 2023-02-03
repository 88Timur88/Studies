// See https://aka.ms/new-console-template for more information

Console.Write("Введите число от 1 до 7:      ");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
if(!isParsedA)
{
    Console.WriteLine($"Введённое значение не соответствует требованиям!!!");
    return;
}

if(a < 8 & a > 0)
{
    if(a == 1) Console.WriteLine("Понедельник");
    if(a == 2) Console.WriteLine("Вторник");
    if(a == 3) Console.WriteLine("Среда");
    if(a == 4) Console.WriteLine("Четверг");
    if(a == 5) Console.WriteLine("Пятница");
    if(a == 6) Console.WriteLine("Суббота");
    if(a == 7) Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Введенное число не является днем недели");
}

