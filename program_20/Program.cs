// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int[] FillArray(int size)
{
  int[] arr = new int[size];
  for (int i = 0; i < size; i++)
  {
    Console.Write($"Введите число №{i+1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }
  return arr;
}

int CounterPositive(int[] array)
{
  int counter = 0;
  int size = array.Length;
  for (int i = 0; i < size; i++)
  {
    if (array[i]>0) counter++;
  }
  return counter;
}

Console.Write("Введите количество вводимых чисел М: ");
int size = Convert.ToInt32(Console.ReadLine());
while (size<=0)
{
  Console.WriteLine("Вы ввели 0 или отрицательное число!" + "\n");
  Console.Write("Введите количество вводимых чисел М: ");
  size = Convert.ToInt32(Console.ReadLine());
}
int[] array = FillArray(size);
int counterPositive = CounterPositive(array);
Console.WriteLine("\n" + $"Количество положительных чисел: {counterPositive}");
