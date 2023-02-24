// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


int[,]matr = new int [,]
{
    6, 5, 4,
    3, 2, 1
};
int max = 0;
int min = 0;

void CoolArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
        }
    }
}
