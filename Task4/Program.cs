// Найти расстояние между точками в пространстве 2D/3D

//расстояние между двумя точками на плоскости
//используем формулу расстояние между двумя точками = квадратный корень из (xb-xa) в квадрате + (yb-ya) в квадрате
//про формулы POW SQRT информацию искала на ютубе и в интернете

Console.Clear();
Console.WriteLine("введите координаты xa: ");
double xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите координаты xb: ");
double xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите координаты ya: ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите координаты yb: ");
double yb = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya), 2));
Console.WriteLine($"расстояние между двумя точками на плоскости {distance}");
