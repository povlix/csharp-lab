using Lab05;
using System.Runtime.InteropServices;

Coords point1 = new Coords(1.0, 1.0);
Console.WriteLine(point1);

Coords point2 = new Coords(1.0, 1.0); ;

if (point1.Equals(point2))
    Console.WriteLine("Equal structs");
else
    Console.WriteLine("Different structs");
point1 = new Coords(1.0, 1.0);
point2 = new Coords(2.0, 2.0);
Coords point3 = new Coords(4.0, 3.0);
Coords point4 = new Coords(7.0, 5.0);
Console.WriteLine($"Line start=({point1.X},{point1.Y})  Line end=({point2.X},{point2.Y})");

Coords[] points = { point1, point2 };
Console.WriteLine(GetDistance(points));

static double GetDistance(Coords[] coords)
{
    double distance = 0;

    for (int i = 0; i < coords.Length-1; i++)
    {
        Coords a = coords[i];
        Coords b = coords[i+1];
        distance += Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
    }
    return distance;


}
//zad2
(double Sqrt, double Log)[] results = new (double Sqrt, double Log)[20];
for (int i = 0; i < 20 ;i++)
{
    results[i] = (Math.Sqrt(i), Math.Log(i));

}
for (int i = 0;i<20; i++)
    Console.WriteLine($"int={i+1} sqrt()={results[i].Sqrt} log()={results[i].Log} ");
(int min, int max) GetMinMax(int[] numbers)
{
    int min = 0;
    int max = 0;
    min = numbers.Min();
    max = numbers.Max();
    return (min, max);
}
Console.WriteLine(GetMinMax(new int[] {1, 2, 4, 5, 7, -3, 0}));
