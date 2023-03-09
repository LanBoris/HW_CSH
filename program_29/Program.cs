// Задача 58: 
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int rows = 2;
int columns = 2;
Console.Write("Введите минимальное значение интервала чисел: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение интервала чисел: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] matrixOne = FillMatrix(rows, columns, minValue, maxValue);
int[,] matrixTwo = FillMatrix(rows, columns, minValue, maxValue);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrixOne);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrixTwo);
Console.WriteLine("Результат перемножения матриц:");
int[,] multiMatrix = FillMultiplyMatrix(matrixOne, matrixTwo);
PrintMatrix(multiMatrix);

/// <summary>
/// Метод заполняет двумерный массив
/// </summary>
/// <param name="rows">Кол-во строк</param>
/// <param name="cols">Кол-во столбцов</param>
/// <param name="minValue">Минимальное значение интервала чисел для рандома</param>
/// <param name="maxValue">Максимальное значение интервала чисел для рандома</param>
/// <returns>Заполненный массив</returns>
int[,] FillMatrix(int rows, int cols, int minValue, int maxValue)
{
  int[,] matrix = new int[rows, cols];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      matrix[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return matrix;
}

/// <summary>
/// Метод выводит двумерный массив на экран
/// </summary>
/// <param name="inputMatrix">Входящий массив, который надо вывести на экран</param>
void PrintMatrix(int[,] inputMatrix)
{
  for (int i = 0; i < inputMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < inputMatrix.GetLength(1); j++)
    {
      Console.Write(inputMatrix[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

/// <summary>
/// Метод создает матрицу - результат перемножения двух матриц
/// </summary>
/// <param name="matrOne">Первая входная матрица для перемножения</param>
/// <param name="matrTwo">Вторая входная матрица для перемножения</param>
/// <returns>Матрицу - результат перемножения</returns>
int[,] FillMultiplyMatrix(int[,] matrOne, int[,] matrTwo)
{
  int countRows = matrOne.GetLength(0);
  int countCols = matrOne.GetLength(1);
  int[,] multiplyMatrix = new int[countRows, countCols];
  for (int i = 0; i < countRows - 1; i++)
  {
    for (int i1 = 1; i1 < countRows; i1++)
    {
      for (int j = 0; j < countCols - 1; j++)
      {
        for (int j1 = 1; j1 < countCols; j1++)
        {
          multiplyMatrix[i, j] = (matrOne[i, j] * matrTwo[i, j]) + (matrOne[i, j1] * matrTwo[i1, j]);
          multiplyMatrix[i, j1] = (matrOne[i, j] * matrTwo[i, j1]) + (matrOne[i, j1] * matrTwo[i1, j1]);
          multiplyMatrix[i1, j] = (matrOne[i1, j] * matrTwo[i, j]) + (matrOne[i1, j1] * matrTwo[i1, j]);
          multiplyMatrix[i1, j1] = (matrOne[i1, j] * matrTwo[i, j1]) + (matrOne[i1, j1] * matrTwo[i1, j1]);
        }
      }
    }
  }
  return multiplyMatrix;
}