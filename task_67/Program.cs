// Задача 67: 
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12 
// 45 -> 9

int GetSumNum(int a)
{
    if (a > 0) a = a % 10 + GetSumNum(a / 10); // 123 a = 123%10 = 3+ ; 123/1 = 12; 12%10 = 2; 2+; 12/10 = 1; 1%10= 1+;
    return (a);                                // 3+2+1 = 6
}

 Console.WriteLine("Enter the number a: ");
 int n = int.Parse(Console.ReadLine()!);
Console.Write(GetSumNum(n)!);
