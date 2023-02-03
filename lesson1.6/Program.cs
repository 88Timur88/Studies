// Показать четные числа от 1 до N

Console.Write("Введите последнее число:   ");
bool isParsed = int.TryParse(Console.ReadLine(), out int N);
if(!isParsed)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
int b = 1;
if(N > 0)
    while (b <= N)
    {
        if(b % 2 == 0)
        {
            Console.WriteLine(b);
            b = b + 1;
        }
        b = b + 1;
    }
else
    Console.WriteLine("Введено отрицательное число");
