// Задача №8.
// Программа показывает все чётые числа в интервале от 1 до N.

Console.Clear();
Console.Write("Введите первое число N = ");
int N = Convert.ToInt32(Console.ReadLine());
int cnt = 1;

if (N == 1)
{
  Console.WriteLine("В данном интервале нет чётных чисел.");
}
else
{
  Console.WriteLine("Четные числа в интервале от 1 до " + N + ".");
  while (cnt < N)
  {
    if (cnt % 2 == 0)
    {
      Console.Write(cnt + " ");
    }
    cnt++;
  }
}
