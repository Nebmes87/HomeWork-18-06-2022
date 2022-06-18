// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int prompt(string message)
{
    Console.Write(message);  
    string NumberStr = Console.ReadLine();
    int number = int.Parse(NumberStr);
    return number;
}
int number = prompt("Введите число: ");
for (int i = 1; i<=number; i++)
{
    double result = Math.Pow(i, 3);
    System.Console.Write($"{result} ");
}
