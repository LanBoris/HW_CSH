// Задача 50. 
// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Clear();

int[,] GetMatrix(int rows, int cols)
{
  int[,] matrix = new int[rows, cols];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
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

int CheckNumber(int number)
{
  while (number < 0)
  {
    Console.WriteLine("Вы ввели отрицательное число!" + "\n");
    Console.Write("Введите снова: ");
    number = Convert.ToInt32(Console.ReadLine());
  }
  return number;
}

void CheckPosition(int[,] matr, int checkRow, int checkColumn)
{
  if ((checkRow < matr.GetLength(0)) && (checkColumn < matr.GetLength(1)))
  {
    Console.WriteLine($"В ячейке [{checkRow}, {checkColumn}] находится" 
                      + $" элемент: {matr[checkRow, checkColumn]}");
  }
  else Console.WriteLine("Такой ячейки нет!");
}

int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
int[,] matrix = GetMatrix(rows, columns);

Console.WriteLine("Введите координаты ячейки.");
Console.Write("Номер строки: ");
int checkRow = Convert.ToInt32(Console.ReadLine());
checkRow = CheckNumber(checkRow);
Console.Write("Номер столбца:");
int checkColumn = Convert.ToInt32(Console.ReadLine());
checkColumn = CheckNumber(checkColumn);

PrintMatrix(matrix);
CheckPosition(matrix, checkRow, checkColumn);