// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double prompt(string message)
{
    Console.Write(message);  
    string NumberStr = Console.ReadLine();
    double number = double.Parse(NumberStr);
    return number;
}
double x1 = prompt("Введите координаты x1: ");
double y1 = prompt("Введите координаты y1: ");
double z1 = prompt("Введите координаты z1: ");
double x2 = prompt("Введите координаты x2: ");
double y2 = prompt("Введите координаты y2: ");
double z2 = prompt("Введите координаты z2: ");

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {distance}");

// или

int promt(string message)
{
    Console.Write(message);  
    string NumberString = Console.ReadLine();
    int num = int.Parse(NumberString);
    return num;
}
double Sqr(double num)
{
    return num * num;
}
double dictans(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double S = Sqr(X2 -X1) + Sqr(Y2 -Y1) + Sqr(Z2 -Z1);
    double result = Math.Sqrt(S);
    return result;
}
int X1 = promt("Введите координаты x1: ");
int Y1 = promt("Введите координаты y1: ");
int Z1 = promt("Введите координаты z1: ");
int X2 = promt("Введите координаты x2: ");
int Y2 = promt("Введите координаты y2: ");
int Z2 = promt("Введите координаты z2: ");

System.Console.WriteLine($"Distans between dots is {dictans(X1,Y1,Z1,X2,Y2,Z2)}");