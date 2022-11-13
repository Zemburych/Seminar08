﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
Console.Write("Введите x - ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y - ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z - ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[x, y, z];

CreateArray(matrix);
WriteArray(matrix);

void CreateArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(1, 9);
            }
            
        }
    }
}
void WriteArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)    
        {
            for (int k = 0; k < matrix.GetLength(3); k++)
            {
                Console.Write(matrix[i, j, k]);
            }
        }
        Console.WriteLine();
    }
}