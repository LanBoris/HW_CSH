// Задача 29: 
// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

void FillArrayOne(int[] array1)
{
  for (int i = 0; i < array1.Length; i++)
  {
    array1[i] = new Random().Next(100, 1000);
  }
}

void FillArrayTwo(int[] array2)
{
  Console.WriteLine("Введите числа массива: ");
  for (int i = 0; i < array2.Length; i++)
  {
    Console.Write($"Элемент с индексом [{i}] : ");
    array2[i] = Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("\n");
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

Console.WriteLine("Каким способом вы хотите заполнить массив?"
                  + "\n" + "1. Случайными числами от 100 до 999."
                  + "\n" + "2. Самостоятельно заполнить с консоли."
                  + "\n" + "Нажмите 1 или 2");
int answer = Convert.ToInt32(Console.ReadLine());
if (answer == 1) FillArrayOne(array);
else if (answer == 2) FillArrayTwo(array);
else
{
  Console.WriteLine("Такого варианта не существует!");
  return;
}

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\n" + $"Массив: [{String.Join("; ", array)}]");
Console.ResetColor();
