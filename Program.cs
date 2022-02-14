using Занятие_12;
Console.WriteLine("Введите радиус окружности:");
double R = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты центра окружности (x0,y0):");
double x0 = Convert.ToDouble(Console.ReadLine());
double y0 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки (x,y):");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double square = Krug.GetSquare(R);
double length = Krug.GetLenght(R);
string point = Krug.GetPoint(R, x0, y0, x, y);
Console.WriteLine($"Длина круга {length} \nПлощадь круга {square}\n{point}");
    