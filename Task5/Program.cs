// Найти расстояние между точками в пространстве 3D

Console.Clear();
Console.WriteLine("введите координаты xa: ");
double xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите координаты xb: ");
double xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите координаты ya: ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите координаты yb: ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите координаты ca: ");
double ca = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите координаты cb: ");
double cb = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya), 2) + Math.Pow((cb - ca), 2));
Console.WriteLine($"расстояние между тремя точками на плоскости {distance}");

