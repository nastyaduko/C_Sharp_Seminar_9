// **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"

// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Введи число: ");
// int N  = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(1,N));

// // ------------------Метод------------------
// string PrintNumbers(int start, int end){
//     if(start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

//Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
 
//M = 1; N = 5. -> "1, 2, 3, 4, 5" 
// M = 4; N = 8. -> "4, 5, 6, 7, 8" 
 
/*Console.WriteLine("Введите число  N"); 
int N = int.Parse(Console.ReadLine()!); 
 
Console.WriteLine("Введите число  M"); 
int M = int.Parse(Console.ReadLine()!); 
 
Console.WriteLine(PrintNumbers(N,M)); 
 
 
string PrintNumbers(int start, int end) 
{ 
    if(start == end) return start.ToString(); 
    return (start + " " + PrintNumbers(start + 1, end)); 
}*/ 
 
// Принять на вход число, вернуть сумму его цифр 
 
/*Console.WriteLine("Введите число  N"); 
int N = int.Parse(Console.ReadLine()!); 
Console.WriteLine(NumberFiguresSum(N)); 
 
int NumberFiguresSum(int N) 
{ 
    if(N == 0) return 0; 
    return (N % 10 + NumberFiguresSum(N / 10)); 
}*/ 
 
// Возведите число А в степень Б с помощью рекурсии 
 
// Console.WriteLine("Введите число A"); 
// int A = int.Parse(Console.ReadLine()!); 
 
// Console.WriteLine("Введите число B"); 
// int B = int.Parse(Console.ReadLine()!); 
 
// Console.WriteLine(PoweredBy(A,B)); 
 
// // --------------method------------------- 
 
// int PoweredBy(int A, int B)
// { 
//     if(B == 0) return 1; 
//     if(B == 1) return A; 
//     return (A * PoweredBy(A, B - 1)); 
// }

// Найдите факториал числа c помощью рекурсии 
 
// Console.WriteLine("Введите число"); 
// int N = int.Parse(Console.ReadLine()!); 
// Console.WriteLine(FactorialOf(N)); 
 
// int FactorialOf(int N) 
// { 
//     if(N == 0) return 1; 
//     if(N == 1) return 1; 
//     return (N * FactorialOf(N - 1)); 
// }

