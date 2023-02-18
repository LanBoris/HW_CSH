// Доп. задание №2:
// Назовем число интересным, если в нем разность максимальной и минимальной
// цифры равняется средней по величине цифре. Напишите программу, 
// которая определяет интересное число или нет. Если число интересное, 
// следует вывести – «Число интересное» иначе «Число неинтересное».
// -> 945 - число интересное, средняя цифра - 4, разница: 9 - 5 = 4

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number <= 0)
{
  Console.Write("Вы ввели отрицательное число или ноль.\n" + "Введите новое число: ");
  number = Convert.ToInt32(Console.ReadLine());
}
string stringNumber = number.ToString();
char[] sN = stringNumber.ToCharArray();
if (sN.Length % 2 == 1)
{
  char cD = sN[sN.Length / 2];
  int centerDigit = (int)Char.GetNumericValue(cD);
  char fD = sN[0];
  int firstDigit = (int)Char.GetNumericValue(fD);
  char lD = sN[sN.Length - 1];
  int lastDigit = (int)Char.GetNumericValue(lD);
  int diff = firstDigit - lastDigit;
  if (centerDigit == diff)
  {
    Console.WriteLine("\n" + $"Число {number} интересное.");
  }
}
else
{
  Console.WriteLine("\n" + $"Число {number} неинтересное.");
}