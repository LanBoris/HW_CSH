// Задача 51: 
// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
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

void PrintMatrix(int[,] matr)
{
  Console.WriteLine("\n" + "В нашем массиве:");
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write(matr[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int CheckRowsColumns(int number)
{
  while (number < 0)
  {
    Console.WriteLine("Вы ввели отрицательное число!" + "\n");
    Console.Write("Введите снова: ");
    number = Convert.ToInt32(Console.ReadLine());
  }
  return number;
}

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
