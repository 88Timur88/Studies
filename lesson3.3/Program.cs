// Написать программу вычисления произведения чисел от 1 до N

Console.Write("ВВедите целое число N  = ");
Console.Write("Введите последнее число:   ");
bool isParsed = int.TryParse(Console.ReadLine(), out int num);
if(!isParsed)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

int i = 1;

int sum = 1;
while(i <= num)
{
    sum = sum * i;
    i++;
}
Console.WriteLine(sum);


// int num = InputInt();

// int[] GetCubeTable(int num)
// {
//     int[] arr = new int[num];
//         for(int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = (int)(Math.Pow(i+1, 3));
//         }
// return arr;
// }

// int[] CubeTable = GetCubeTable(num);

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
// PrintArray(CubeTable);

// int sum = 0;
// while(i < arr.Length)
// {
//     sum = sum + Array[i];
//     i++;
// }
// Console.WriteLine(sum);