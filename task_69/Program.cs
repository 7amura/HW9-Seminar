// Задача 69: 
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//  A = 3; B = 5 -> 243 (35) 
//  A = 2; B = 3 -> 8

int Degree(int a, int b)
{
    if(b == 0) return 1;
    else return a * Degree(a, b - 1); 
}

 Console.WriteLine("Enter a positive number a: ");
 int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a positive number b: ");
 int m = int.Parse(Console.ReadLine()!);
 Console.Write($"The number {n} in the power {m} is equal: {Degree(n,m)}");
