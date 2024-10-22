// See https://aka.ms/new-console-template for more information

//zadanie 1
int n = 10;
do
{
    Console.WriteLine(n);
    n--;
} while (n >=0);

//zadanie 2

string haslo;

do
{
    Console.WriteLine("podaj haslo");
    haslo = Console.ReadLine();

} while (haslo != "koniec");

//zadanie 3

int x = 0;
Console.WriteLine("liczby parzyste:");
while (x<= 100)
{
    if ( x % 2 == 0)
    Console.WriteLine(x);
    x++;
}

// zadanie 4

for (int i = 1; i <= 15; i++)
    Console.WriteLine($"Square of {i} equals {i * i}");

for (int i = 1; i <= 15; i++)
{
    string txt = "Square of " + i + " equals " + i * i;
}

//zadanie 5
List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };
foreach (int z in numbers)
{
    if (z % 7 == 0)
        Console.Write($"{z}");
}

// zadanie 7
double[] dArray = new double[20];
for (int j = 0; j < 20; j++)
{
    dArray[j] = Math.Sqrt(j);
    Console.WriteLine("j: " + dArray[j]);
}

//zadanie 8
int[,] m = new int[3, 4];
for (int column= 0; column < 3; column++)
{
    for (int row=0; row < 4; row++)
    {
        m[row, column] = column + row;
    }
}
int[,] t = new int[4, 3];
for (int column = 0; column <3; column++)
{
    for (int row = 0; row < 4; row++)
    {
        t[row, column] = m[column, row];
    }
}

//zadanie 10

void PrintUpperCase(string txt)
{
    Console.WriteLine(txt.ToUpper());

}
PrintUpperCase("tekst do driku");
//zadanie 13
void PrintConsoleSquare(int x, int y)
{
    for (int i = 0; i < x; i++)
        Console.Write("$");

    Console.WriteLine();

    for (int i = 0; i < y-2; i++)
    {
        Console.Write("$");
        
        for (int j = 0; j < x - 2; j++)
        {
            Console.Write(" ");
        }
        Console.Write("$");
        Console.WriteLine();
    }

    for (int i = 0; i < x; i++)
        Console.Write("$");

}
PrintConsoleSquare(15, 15);

// zadanie 12
string EvenOrOdd1(int toCheck)
{
    string retStr = "";
    if (toCheck % 2 == 0)
    {
        retStr = "Even";
    }
    else
    {
        retStr = "Odd";
    }
    return retStr;
}
string EvenOrOdd2(int toCheck)
{
    if (toCheck % 2 == 0)
        return "Even";
    else
        return "Odd";
}
string EvenOrOdd3(int toCheck)
{
    return toCheck % 2 == 0 ? "Even" : "Odd";
}

//zadanie 11