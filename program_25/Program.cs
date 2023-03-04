// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

double[,] GetMatrix(int rows, int columns)
{
  double[,] matr = new double[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matr[i, j] = Math.Round(10 * (new Random().NextDouble()), 0);
    }
  }
  return matr;
}

void PrintMatrix(double[,] matr)
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

int CheckNumber(int number)
{
  while (number <= 0)
  {
    Console.WriteLine("Вы ввели отрицательное число!" + "\n");
    Console.Write("Введите снова: ");
    number = Convert.ToInt32(Console.ReadLine());
  }
  return number;
}

double[] AverageByColumns(double[,] inputMatrix)
{
  int countColumns = inputMatrix.GetLength(1);
  int countRows = inputMatrix.GetLength(0);
  int k = 0;
  double[] avgColumns = new double[countColumns];
  for (int i = 0; i < countColumns; i++)
  {
    double sumColumn = 0;
    for (int j = 0; j < countRows; j++)
    {
      sumColumn += inputMatrix[j, i];
    }
    avgColumns[k] = Math.Round((sumColumn / countRows), 2);
    k++;
  }
  return avgColumns;
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
rows = CheckNumber(rows);
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
columns = CheckNumber(columns);

double[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
double[] resultArray = AverageByColumns(matrix);
Console.WriteLine($"Среднее арифметическое элементов по столбцам: " 
                  + $"[{String.Join("; ", resultArray)}]");