// Показать натуральные числа от N до 1, N задано

Console.Write("ВВедите целое число N  = ");
bool isParsed = int.TryParse(Console.ReadLine(), out int num);
if(!isParsed)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

int i = 1;


while(i <= num)
{
    Console.Write($"{num} ");
    num = num - 1;
}
