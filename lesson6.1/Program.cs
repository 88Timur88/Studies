// Показать двумерный массив размером m×n заполненный вещественными числами


Console.Write("Введите последнее число m:   ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
if(!isParsedM)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
Console.Write("Введите последнее число n:   ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if(!isParsedN)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
double[,]matrix = new double [m, n];
void PrintArray(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}");
        }
    Console.WriteLine();
    }
}

void FillArray(double [,] mat)
{
    for(int i = 0; i < mat.GetLength(0); i++)
    {
        for(int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().NextDouble();
        }
    Console.WriteLine();
    }
}


FillArray(matrix);
PrintArray(matrix);
