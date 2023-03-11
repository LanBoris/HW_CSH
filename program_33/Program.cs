// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
numberM = CheckNumberPositive(numberM);
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
numberN = CheckNumberPositive(numberN);

Console.WriteLine("\n" + $"Сумма натуральных чисел от M = {numberM} до N = {numberN}" 
                  + $" равна: {SumNumbersInterval(numberM, numberN)}");

/// <summary>
/// Метод находящий сумму элементов в интервале от M до N
/// </summary>
/// <param name="firstNumber">Начальное число интервала M</param>
/// <param name="lastNumber">Конечное число интервала N</param>
/// <returns>Сумма элементов от M до N</returns>
int SumNumbersInterval(int firstNumber, int lastNumber)
{
  if (firstNumber == lastNumber) return lastNumber;
  return (firstNumber+SumNumbersInterval(firstNumber+1, lastNumber));
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