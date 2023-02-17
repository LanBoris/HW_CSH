//  Задача 10: 
//  Напишите программу, которая принимает на вход трёхзначное число 
//  и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите число = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
  int result = number % 100 / 10;
  Console.WriteLine($"Второй цифрой числа {number} является цифра: {result}.");
}
else
{
  Console.WriteLine("Число не является трехзначным или является отрицательным.");
}
