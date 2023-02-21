// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int GetDegree(int a, int b)
{
  int result = 1;
  for (int i = 1; i <= b; i++)
  {
    result = result * a;
  }
  return result;
}

Console.Write("Введите число, которое надо возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень в которую надо возвести число: ");
int b = Convert.ToInt32(Console.ReadLine());
while (a < 0 || b < 0)
{
  if (a < 0 || b < 0) Console.WriteLine("Вы ввели отрицательое число");
  Console.Write("Введите число, которое надо возвести в степень: ");
  a = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите степень в которую надо возвести число: ");
  b = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Возводя число {a} в степень {b} получим: {(GetDegree(a, b))}");
