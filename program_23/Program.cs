// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] GetMatrix(int rows, int columns)
{
  double[,] matr = new double[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matr[i, j] = Math.Round(((new Random().NextDouble())*(new Random().Next(-10,10))), 1);
    }
  }
  return matr;
}

void PrintMatrix(double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write(matr[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int CheckNumber(int number)
{
  while (number <= 0)
  {
    Console.WriteLine("Вы ввели 0 или отрицательное число!" + "\n");
    Console.Write("Введите снова: ");
    number = Convert.ToInt32(Console.ReadLine());
  }
  return number;
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
rows = CheckNumber(rows);
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
columns = CheckNumber(columns);
double[,] matrix = GetMatrix(rows, columns);
Console.WriteLine("\n" + $"Массив случайных вещественных чисел:");
PrintMatrix(matrix);