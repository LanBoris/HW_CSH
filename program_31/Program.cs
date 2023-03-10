// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int rows = 4;
int columhs = 4;
int[,] matrix = CreateSnakeArray(rows, columhs);
PrintMatrix(matrix);

/// <summary>
/// Метод, который заполняет двумерный массив по спирали
/// </summary>
/// <param name="rows">Кол-во строк массива</param>
/// <param name="cols">Кол-во столбцов массива</param>
/// <returns>Заполненный двумерный массив</returns>
int[,] CreateSnakeArray(int rows, int cols)
{
  int[,] matrix = new int[rows, cols];
  int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = cols;

  for (int i = 0; i < matrix.Length; i++)
  {
    matrix[col, row] = i + 1;
    if (--gran == 0)
    {
      gran = cols * (dirChanges % 2) + rows * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
      int temp = dx;
      dx = -dy;
      dy = temp;
      dirChanges++;
    }
    row += dx;
    col += dy;
  }
  return matrix;
}

/// <summary>
/// Метод выводящий двумерный массив на экран
/// </summary>
/// <param name="inputMatrix">Входящий массив, который надо вывести на экран</param>
void PrintMatrix(int[,] inputMatrix)
{
  for (int i = 0; i < inputMatrix.GetLength(1); i++)
  {
    for (int j = 0; j < inputMatrix.GetLength(0); j++)
    {
      Console.Write(inputMatrix[i, j] + "\t");
    }
    Console.WriteLine();
  }
}