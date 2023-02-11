// Задача №2.
// Программа принимает на вход два числа, и показывает, какое из них большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
  Console.WriteLine("Числа равны.");
}
else
{
  if (a > b)
  {
    Console.WriteLine("Число а = " + a + " большее. " + "Число b = " + b + " меньшее. ");
  }
  else
  {
    Console.WriteLine("Число a = " + a + " меньшее. " + "Число b = " + b + " большее. ");
  }
}