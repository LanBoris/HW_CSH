// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

void FillArray(int[] array, int minValue, int maxValue)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minValue, maxValue);
  }
}

void PrintArray(int[] array)
{
  Console.WriteLine("\n" + $"Заданный массив [{String.Join("; ", array)}]" + "\n");
}

void SumOddIndexNumbers(int[] array, int size)
{
  int sum = 0;
  for (int i = 1; i < size; i += 2)
  {
    sum += array[i];
  }
  Console.WriteLine($"Сумма чисел с нечетными индексами равна {sum}." + "\n");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
while (size <= 0)
{
  Console.Write("Размер массива не может быть отрицательным или нулевым."
                  + "\n" + "Введите новый размер: ");
  size = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Для генерации массива введите границы интервала случайных чисел:");
Console.Write("- Введите минимальное значение интервала: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("- Введите максимальное значение интервала: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array, minValue, maxValue);
PrintArray(array);
SumOddIndexNumbers(array, size);