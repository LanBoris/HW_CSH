// Задача 34: 
// Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
}

void PrintArray(int[] array)
{
  Console.WriteLine("\n" + $"Заданный массив [{String.Join("; ", array)}]" + "\n");
}

void CounterEven(int[] array, int size)
{
  int count = 0;
  for (int i = 0; i < size; i++)
  {
    if (array[i] % 2 == 0) count++;
  }
  Console.WriteLine($"В заданном массиве количество четных чисел равно {count}." + "\n");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
while (size <= 0)
{
  Console.Write("Размер не может быть отрицательным или нулевым."
                  + "\n" + "Введите новый размер: ");
  size = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[size];
FillArray(array);
PrintArray(array);
CounterEven(array, size);