// Задача 42
// Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();

// Первый вариант решения (математический)
Console.Write("Введите десятичное число для преобразования: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number<=0)
{
  Console.WriteLine("Вы ввели 0 или отрицательное число!" + "\n");
  Console.Write("Введите десятичное число для преобразования: ");
  number = Convert.ToInt32(Console.ReadLine());
}
int remnant = 0;
string result = "";
if (number == 0) result = "0";
else
{
  while (number >= 1)
  {
    remnant = number % 2;
    number = number / 2;
    result = Convert.ToString(remnant) + result;
  }
}
Console.WriteLine($"В двоичной системе счисления это: {result}");

// Второй вариант решения (исследовательско-читерский)
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// while (number<=0)
// {
//   Console.WriteLine("Вы ввели 0 или отрицательное число!" + "\n");
//   Console.Write("Введите десятичное число для преобразования: ");
//   number = Convert.ToInt32(Console.ReadLine());
// }
// string result = Convert.ToString(number, 2);
// Console.WriteLine($"В двоичной системе счисления это: {result}");