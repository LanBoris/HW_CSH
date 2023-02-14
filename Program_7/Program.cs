//  Задача 15: 
//  Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите цифру дня недели = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
  if (number > 5)
  {
    Console.WriteLine("Этот день недели является выходным.");
  }
  else
  {
    Console.WriteLine("Этот день недели является рабочим.");
  }
}
else
{
  Console.WriteLine("Такого дня недели не существует.");
}