// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N <= 0)
{
  if (N < 0)
  {
    Console.WriteLine("Введенное число отрицательное, мы можем умножить число на -1");
    Console.WriteLine("Yes/No?");
    string answer = (Console.ReadLine()!.ToLower());
    if (answer == "yes" || answer == "да" || answer == "y")
    {
      N = N * -1;
    }
    else
    {
      Console.Write("Введите новое число N: ");
      N = Convert.ToInt32(Console.ReadLine());
    }
  }
  else if (N == 0)
  {
    Console.Write("Вы ввели 0, введите новое число N: ");
    N = Convert.ToInt32(Console.ReadLine());
  }
}
Console.WriteLine("\n" + $"Кубы чисел в интервале от 1 до {N}:");
for (int i = 1; i <= N; i++)
{
  Console.Write(Math.Pow(i, 3) + "\t");
}