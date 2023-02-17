// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 10000 || number > 99999)
{
  Console.WriteLine($"Число {number} не является пятизначным или оно отрицательное или равно 0!");
  Console.Write("Введите новое число: ");
  number = Convert.ToInt32(Console.ReadLine());
}

if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
{
  Console.WriteLine("\n" + $"Число {number} является палиндромом.");
}
else
{
  Console.WriteLine("\n" + $"Число {number} не является палиндромом.");
}
