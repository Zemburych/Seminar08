// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
Console.Write("Введите количество строк - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов - ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mass = new int[m, n];
Random rand = new Random();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = rand.Next(1, 9);
        Console.Write($"{mass[i, j]}" + " ");
    }
    Console.WriteLine();
}

// проверка условия
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int max = 0; max < mass.GetLength(1) - 1; max++)
        {
            if (mass[i, max] < mass[i, max + 1]) // двигаем максимальное число
            {
                int temp = mass[i, max + 1];
                mass[i, max + 1] = mass[i, max];
                mass[i, max] = temp;
            }
        }
    }
}
Console.WriteLine("Новый массив:");
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write($"{mass[i, j]}" + " ");
    }
    Console.WriteLine();
}
