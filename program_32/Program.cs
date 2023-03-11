// Задача 64: 
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
number = CheckNumberPositive(number);
Console.WriteLine("\n" + $"Числа от N = {number} до 1 ->\t {PrintNumbers(number, 1)}");

/// <summary>
/// Метод выводящий все натуральные числа от num до 1
/// </summary>
/// <param name="num">Начальная число</param>
/// <param name="end">Конечное число</param>
/// <returns>Строка с числами от num до 1</returns>
string PrintNumbers(int num, int end)
{
  if (num == 1) return end.ToString();
  return (num + ", " + PrintNumbers(num-1, end));
}

/// <summary>
/// Метод проверяет число на положительность
/// </summary>
/// <param name="num">Входящее число для проверки</param>
/// <returns>Положительное число</returns>
int CheckNumberPositive(int num)
{
  while (num<=0)
  {
    Console.WriteLine("Вы ввели отрицательное число или 0.");
    Console.Write("Введите новое положительное число: ");
    num = Convert.ToInt32(Console.ReadLine());
  }
  return num;
}