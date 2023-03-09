// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.Write("Введите количество строк для трехмерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
rows = CheckRowsColumnsDepth(rows);
Console.Write("Введите количество столбцов для трехмерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
columns = CheckRowsColumnsDepth(columns);
Console.Write("Введите размер глубины для трехмерного массива: ");
int depth = Convert.ToInt32(Console.ReadLine());
depth = CheckRowsColumnsDepth(depth);

int[,,] matrix3D = FillMatrix(rows, columns, depth);
Console.WriteLine("\n" + $"Сформированный массив размером: {rows} x {columns} x {depth} ");
PrintMatrix(matrix3D);

/// <summary>
/// Метод заполняющий трехмерный массив целыми уникальными двухзначными числами.
/// </summary>
/// <param name="rows">Кол-во строк</param>
/// <param name="cols">Кол-во столбцов</param>
/// <param name="depth">Размер глубины</param>
/// <returns>Заполененный трехмерный массив</returns>
int[,,] FillMatrix(int rows, int cols, int depth)
{
  var random = new Random();
  int[] arrayOfUniqueNumbers = Enumerable.Range(10, 90).OrderBy(t => random.Next()).ToArray();
  int indexOfArray = 0;
  int[,,] matrix = new int[rows, cols, depth];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      for (int k = 0; k < depth; k++)
      {
        matrix[i, j, k] = arrayOfUniqueNumbers[indexOfArray];
        indexOfArray++;
      }
    }
  }
  return matrix;
}

/// <summary>
/// Метод выводящий трехмерный массив на экран, с индексами элементов
/// </summary>
/// <param name="inputMatrix">Входящий трехмерный массив для вывода на экран</param>
void PrintMatrix(int[,,] inputMatrix)
{
  for (int i = 0; i < inputMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < inputMatrix.GetLength(1); j++)
    {
      for (int k = 0; k < inputMatrix.GetLength(2); k++)
      {
        Console.Write($"{inputMatrix[i, j, k]}({i},{j},{k})" + "\t");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

/// <summary>
/// Метод проверяющий числа на отрицательность и равность 0.
/// </summary>
/// <param name="number">Входящее число</param>
/// <returns>Возвращает положительное число</returns>
int CheckRowsColumnsDepth(int number)
{
  while (number <= 0)
  {
    Console.WriteLine("Вы ввели отрицательное число или 0!" + "\n");
    Console.Write("Введите снова: ");
    number = Convert.ToInt32(Console.ReadLine());
  }
  return number;
}
