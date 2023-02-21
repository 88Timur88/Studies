// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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

int[,]matrix = new int [m, n];
void PrintArray(int[,] matrix)
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

void FillArray(int [,] mat)
{
    for(int i = 0; i < mat.GetLength(0); i++)
    {
        for(int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = m + n;
        }
    Console.WriteLine();
    }
}

void FillSquareArray(int [,] mat)
{
    for(int i = 0; i < mat.GetLength(0); i++)
    {
        for(int j = 0; j < mat.GetLength(1); j++)
        {
            i = i % 2;
            j = j % 2;
            if(i == 0 & j == 0)
            {
                mat[i, j] = mat[i, j] * mat[i, j];
            }
            else i++;
        }
    }
    Console.WriteLine();
}



FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FillSquareArray(matrix);
PrintArray(matrix);
