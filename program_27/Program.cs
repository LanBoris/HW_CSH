// Задача 54: 
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
rows = CheckRowsColumns(rows);
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
columns = CheckRowsColumns(columns);

Console.Write("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(rows, columns, minValue, maxValue);
Console.WriteLine("\n" + "Заданный двумерный массив:");
PrintMatrix(matrix);
Console.WriteLine("Двумерный массив с отсортированными по убыванию строками:");
SortRowsMatrixDescending(matrix);
PrintMatrix(matrix);

/// <summary>
/// Метод заполняющий двумерный массив.
/// </summary>
/// <param name="rows">Кол-во строк</param>
/// <param name="cols">Кол-во столбцов</param>
/// <param name="minValue">Минимальное число интервала рандомайзера</param>
/// <param name="maxValue">Максимальное число интервала рандомайзера</param>
/// <returns></returns>
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
/// Метод выводящий двумерный массив на экран.
/// </summary>
/// <param name="inputMatrix">Массив, который надо вывести на экран</param>
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
/// Метод проверяющий вводимые числа на отрицательность и равность нулю.
/// </summary>
/// <param name="number">Входящее число</param>
/// <returns></returns>
int CheckRowsColumns(int number)
{
  while (number <= 0)
  {
    Console.WriteLine("Вы ввели отрицательное число или 0!" + "\n");
    Console.Write("Введите снова: ");
    number = Convert.ToInt32(Console.ReadLine());
  }
  return number;
}

/// <summary>
/// Метод сортирует каждую строку двумерного массива по убыванию.
/// </summary>
/// <param name="inputMatr">Входной массив для сортировки</param>
void SortRowsMatrixDescending(int[,] inputMatr)
{
  int temp = 0;
  int countRows = inputMatr.GetLength(0);
  int countCols = inputMatr.GetLength(1);
  for (int i = 0; i < countRows; i++)
  {
    for (int j = 0; j < countCols - 1; j++)
    {
      for (int k = j+1; k < countCols; k++)
      {
        if (inputMatr[i,j] < inputMatr[i, k])
        {
          temp = inputMatr[i, j];
          inputMatr[i, j] = inputMatr[i, k];
          inputMatr[i, k] = temp;
        }
      }
    }
  }
}
