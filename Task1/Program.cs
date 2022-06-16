// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int prompt(string message)
{
    Console.Write(message);  
    string NumberStr = Console.ReadLine();
    int number = int.Parse(NumberStr);
    return number;
}
int number = prompt("Введите число: ");
int OldNumber = number;
int newNumber = 0;
while (number>0)
{
    int A = number%10;
    newNumber = newNumber*10 + A;
    number = number/10;
}
if (newNumber == OldNumber) System.Console.WriteLine($"{OldNumber} -> да");
else System.Console.WriteLine($"{OldNumber} -> нет");