// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

void FillArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().NextDouble();
    array[i] = Math.Round(array[i] * 100, 2);
  }
}

void PrintArray(double[] array)
{
  Console.WriteLine("\n" + $"Заданный массив [{String.Join("; ", array)}]" + "\n");
}

void DiffMaxMin(double[] array)
{
  double max = Math.Round(array.Max(), 2);
  double min = Math.Round(array.Min(), 2);
  double diffMaxMin = Math.Round(max - min, 2);
  Console.WriteLine($"Разница между максимальным: {max} и минимальным: {min} элементами массива равна: {diffMaxMin}" + "\n");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
while (size <= 0)
{
  Console.Write("Размер массива не может быть отрицательным или нулевым."
                  + "\n" + "Введите новый размер: ");
  size = Convert.ToInt32(Console.ReadLine());
}
double[] array = new double[size];
FillArray(array);
PrintArray(array);
DiffMaxMin(array);