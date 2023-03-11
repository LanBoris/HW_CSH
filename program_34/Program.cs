// Задача 68: 
// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
numberM = CheckNumber(numberM);
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
numberN = CheckNumber(numberN);

Console.WriteLine("\n" + $"Функция Аккермана A({numberM},{numberN}) равна:" 
                       + $"{GetAckermannFunction(numberM, numberN)}");

/// <summary>
/// Метод вычисляющий функцию Аккермана А(m,n) 
/// </summary>
/// <param name="numM">Входящее число m</param>
/// <param name="numN">Входящее число n</param>
/// <returns>Результат вычисления функции Аккермана A(m,n)</returns>
int GetAckermannFunction(int numM, int numN)
{
  if (numM == 0) return numN+1;
  if (numN == 0) return GetAckermannFunction(numM-1, 1);
  return GetAckermannFunction(numM-1, GetAckermannFunction(numM, numN-1));
}

/// <summary>
/// Метод проверяет число на отрицательность
/// </summary>
/// <param name="num">Входящее число для проверки</param>
/// <returns>Неотрицательное число</returns>
int CheckNumber(int num)
{
  while (num<0)
  {
    Console.WriteLine("Вы ввели отрицательное число.");
    Console.Write("Введите новое число: ");
    num = Convert.ToInt32(Console.ReadLine());
  }
  return num;
}