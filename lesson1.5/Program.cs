// Выяснить является ли число чётным

Console.Write("Введите целое число:");
bool isParsed = int.TryParse(Console.ReadLine(), out int a);
if(!isParsed)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

int sum = a % 2;
if( sum == 0) Console.WriteLine("Введенное число является четным");
else Console.WriteLine("Введенное число не является четным");