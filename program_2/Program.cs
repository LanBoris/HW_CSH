// Задача №4.
// Программа принимает на вход 3 числа, и определяет максимальное из них.

Console.Clear();
Console.Write("Введите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число c = ");
int c = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
  if (b == c)
  {
    Console.WriteLine("Числа равны.");
  }
  else
  {
    if (a > b)
    {
      if (a > c)
      {
        Console.WriteLine("Число a = " + a + " является максимальным.");
      }
    }
    if (b > a)
    {
      if (b > c)
      {
        Console.WriteLine("Число b = " + b + " является максимальным.");
      }
    }
    if (c > a)
    {
      if (c > b)
      {
        Console.WriteLine("Число c = " + c + " является максимальным.");
      }
    }
  }
}
else
{
  if (a > b)
  {
    if (a > c)
    {
      Console.WriteLine("Число a = " + a + " является максимальным.");
    }
  }
  if (b > a)
  {
    if (b > c)
    {
      Console.WriteLine("Число b = " + b + " является максимальным.");
    }
  }
  if (c > a)
  {
    if (c > b)
    {
      Console.WriteLine("Число c = " + c + " является максимальным.");
    }
  }
}
