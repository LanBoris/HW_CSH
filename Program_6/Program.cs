//  Задача 13: 
//  Напишите программу, которая выводит третью цифру
//  заданного семизначного числа или сообщает, что третьей цифры нет.

//  ДОП: цифра третья может быть как с левой стороны, так и с правой.

Console.Clear();
Console.Write("Введите число = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number <= 0)
{
  Console.WriteLine($"Число {number} не имеет третьей цифры или является отрицательным.");
}
else if (number >= 1000000 && number <= 9999999)
{
  int result = number / 10000 % 100 % 10;
  int result2 = number / 100 % 10000 % 1000 % 100 % 10;
  Console.WriteLine($"Третьей цифрой числа {number} c ЛЕВОЙ стороны является {result}.");
  
  Console.WriteLine($"Третьей цифрой числа {number} c ПРАВОЙ стороны является {result2}.");
}
else
{
  Console.WriteLine($"Число {number} не является семизначным.");
}
