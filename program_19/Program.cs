// Доп. задачка: Задача 37: 
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

void FillArray(int[] array, int maxValue)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1,maxValue);
  }
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число интервала для заполнения массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array, maxValue);
int lastIndex = size - 1;
int j = 0;
int sizeMultiplyArray = size/2;
if (size % 2 == 1) sizeMultiplyArray = (size / 2) + 1;
int[] multiplyArray = new int[sizeMultiplyArray];
for (int i = 0; i < size/2; i++)
{
  multiplyArray[j] = array[i] * array[lastIndex - i];
  j++;
}
if (size%2==1) multiplyArray[sizeMultiplyArray-1]=array[size/2];
Console.WriteLine("\n" + $"Заданный массив [{String.Join("; ", array)}]");
Console.WriteLine("\n" + $"Массив произведения пар [{String.Join("; ", multiplyArray)}]" + "\n");

