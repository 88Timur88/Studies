// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void NewArray(int[]array)
{
    int l = array.Length;
    int index = 0;
    while(index < l)
{
    array[index] = new Random().Next();
        index++;
    }
}
int [] array = new int [4];
NewArray(array);

Console.WriteLine(string.Join(",",array));
Console.WriteLine();

int result;
int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    result = i % 2;
    if(result == 0)
        {
            sum = sum + array[i];
        }
    
}


Console.WriteLine($"Сумма чисел, находящихся на четных позициях, равна {sum}");