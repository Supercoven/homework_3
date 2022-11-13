Console.WriteLine("Введите координаты точки A по оси x");
double dotAX = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки A по оси y");
double dotAY = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки A по оси z");
double dotAZ = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси x");
double dotBX = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси y");
double dotBY= double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси z");
double dotBZ= double.Parse(Console.ReadLine());

void Distance()
{
double distance = Math.Sqrt(Math.Pow(dotBX - dotAX, 2) + Math.Pow(dotBY - dotAY, 2) + Math.Pow(dotBZ - dotAZ, 2));
Console.WriteLine($"Расстояние между тремя точками = {distance}");
}

Distance();

