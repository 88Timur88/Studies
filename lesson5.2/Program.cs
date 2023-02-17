// Показать числа Фибоначчи

Console.Write("Введите первое число:   ");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
if(!isParsedA)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
Console.Write("Введите второе число:   ");
bool isParsedb = int.TryParse(Console.ReadLine(), out int b);
if(!isParsedb)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

Console.Write("Введите число, до которого считать числа фибоначчи:   ");
bool isParsedNum = int.TryParse(Console.ReadLine(), out int num);
if(!isParsedNum)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
int sum = 0;

while(num >= sum)
{
    sum = a + b;
    Console.Write("{0}  ", sum);
    a = b;
    b = sum;
}

