// Написать программу показывающие первые N чисел, для которых каждое следующее
//  равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

Console.Write("Введите второе целое число N  = ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if(!isParsedN)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
int i = 1;
int a = 1;
int b;
int sum = 0;
while(i <= n)
{
    b = sum;
    sum = sum + a;
    Console.Write($"{sum} ");
    a = b;
    i++;
    
}

