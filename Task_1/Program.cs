//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Enter firs number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int B = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(A, B);

Console.WriteLine($"{A} ^ {B} = {result}");


