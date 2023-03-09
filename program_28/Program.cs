// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите количество строк для прямоугольного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
rows = CheckRowsColumns(rows);
Console.Write("Введите количество столбцов для прямоугольного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
columns = CheckRowsColumns(columns);
if (rows == columns)
{
  Console.WriteLine("Вы ввели одинаковое число строк и столбцов.");
  return;
}

Console.Write("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(rows, columns, minValue, maxValue);
Console.WriteLine("\n" + "Заданный двумерный массив:");
PrintMatrix(matrix);
FindMinSumRow(matrix);

/// <summary>
/// Метод заполняющий двумерный массив.
/// </summary>
/// <param name="rows">Кол-во строк</param>
/// <param name="cols">Кол-во столбцов</param>
/// <param name="minValue">Минимальное число интервала рандомайзера</param>
/// <param name="maxValue">Максимальное число интервала рандомайзера</param>
/// <returns>Заполненный двумерный массив</returns>
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
/// <returns>Положительное число</returns>
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
/// Метод ищет строку с наименьшей суммой элементов
/// </summary>
/// <param name="inputMatrix">Входной двумерный массив для обработки</param>
void FindMinSumRow(int[,] inputMatrix)
{
  int countRows = inputMatrix.GetLength(0);
  int countCols = inputMatrix.GetLength(1);
  int tempSum = 0;
  int indexMinSumRow = 0;
  for (int m = 0; m < countCols; m++)
  {
    tempSum += inputMatrix[0, m];
  }
  for (int i = 0; i < countRows; i++)
  {
    int sum = 0;
    for (int j = 0; j < countCols; j++)
    {
      sum += inputMatrix[i, j];
    }
    if (sum < tempSum)
    {
      tempSum = sum;
      indexMinSumRow = i;
    }
  }
  Console.WriteLine("\n" + $"Строка с минимальной суммой элементов: {indexMinSumRow + 1}");
}
