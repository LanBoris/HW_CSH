// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату точки A по оси x: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A по оси y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A по оси z: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("\n" + "Введите координату точки B по оси x: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси z: ");
int zB = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n" + $"Расстояние между точками равняется {result:f2}");
Console.ResetColor();
