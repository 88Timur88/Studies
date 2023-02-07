// Найти расстояние между точками в пространстве 2D/3D

int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());

int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

double result = GetDistanceBetweenPoints(x1, y1, x2, y2, z1, z2);
Console.WriteLine(result);

double GetDistanceBetweenPoints(int x1, int y1, int x2, int y2, int z1, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2)), 2);
};
