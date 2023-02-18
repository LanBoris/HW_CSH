// Доп. задание №1:
// Представим банк, в котором алгоритм начисления процента по вкладу
// зависит от суммы вклада. На вход будет подаваться число (сумма вклада). 
// При значении меньше 100, будет начислено 5 %, если значение находится 
// в диапазоне от ста до двухсот — 7 %, если больше — 10 %. 
// Отработав, программа должна вывести общую сумму с начисленными процентами.

Console.Clear();
Console.Write("Введите сумму вклада: ");
int dep = Convert.ToInt32(Console.ReadLine());

while (dep <= 0)
{
  Console.WriteLine("Введенная сумма меньше либо равна 0.");
  Console.Write("Введите другую сумму вклада: ");
  dep = Convert.ToInt32(Console.ReadLine());
}
if (dep > 0 && dep < 100)
{
  var finalDep = dep * 1.05;
  Console.WriteLine("\n" + "На ваш вклад будет начисленно 5%.");
  Console.WriteLine($"Общая сумма с процентами: {finalDep:f2}.");
}
else if (dep >= 100 && dep <= 200)
{
  var finalDep = dep * 1.07;
  Console.WriteLine("\n" + "На ваш вклад будет начисленно 7%.");
  Console.WriteLine($"Общая сумма с процентами: {finalDep:f2}.");
}
else if (dep > 200)
{
  var finalDep = dep * 1.10;
  Console.WriteLine("\n" + "На ваш вклад будет начисленно 10%.");
  Console.WriteLine($"Общая сумма с процентами: {finalDep:f2}.");
}
