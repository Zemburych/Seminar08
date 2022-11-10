// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.Write("Введите количество строк и столбцов в прямоугольном массиве - ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n];

CreateArray(array);
WriteArray(array);

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SummElemets(int[,] array, int i)
{
    int summ = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        summ = summ + array[i, j];
    }
    return summ;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine($"Сумма строки {i} - " + SummElemets(array, i));
}

int minsumm = 0;
int summLine = SummElemets(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = SummElemets(array, i);
    if (summLine > temp)
    {
        summLine = temp;
        minsumm = (i);
    }
}
Console.Write("Строка с наименьшей суммой - " + minsumm);
