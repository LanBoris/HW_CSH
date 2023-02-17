// Задача №6.
// Программа проверяет является ли число чётным.

Console.Clear();
Console.Write("Введите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
  Console.WriteLine("Число a = " + a + " является четным.");
}
else
{
  Console.WriteLine("Число a = " + a + " является нечётным.");
}