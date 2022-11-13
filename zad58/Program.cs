// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе 
// равно числу строк во втором; в этом случае говорят, что матрицы согласованы. В частности, умножение 
// всегда выполнимо, если оба сомножителя — квадратные матрицы одного и того же порядка.

Console.Clear();
Console.Write("Введите количество строк matrix01 - ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов matrix01 и число строк matrix02 - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов matrix02 - ");
int o = Convert.ToInt32(Console.ReadLine());

int[,] matrix01 = new int[n, m];
int[,] matrix02 = new int[m, o];

CreateArray(matrix01);
Console.WriteLine("Первая матрица:");
WriteArray(matrix01);

CreateArray(matrix02);
Console.WriteLine("Вторая матрица:");
WriteArray(matrix02);

// заполнение матрицы
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,9);
    }
  }
}
// печать матрицы
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

int[,] resultMatrix = new int[n,o];

// произведение матриц
void matrixresult(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int temp = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        temp += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = temp;
    }
  }
}
matrixresult(matrix01, matrix02, resultMatrix);
Console.WriteLine("Произведение матриц:");
WriteArray(resultMatrix);
