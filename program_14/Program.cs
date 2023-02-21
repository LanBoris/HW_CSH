// Задача 27: 
// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number<=0)
{
  Console.WriteLine("Вы ввели отрицательное число или 0.");
  Console.Write("Введите новое число: ");
  number = Convert.ToInt32(Console.ReadLine());
}

int summ = 0;
int tempNumber = number;

while (tempNumber > 0)
{
  summ += tempNumber % 10;
  tempNumber /= 10;
}

Console.WriteLine("\n" + $"Сумма цифр числа {number} равна: {summ}");
