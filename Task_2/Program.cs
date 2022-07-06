//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int Sumnumbers(int number)
{
    int size = Convert.ToString(number).Length;
    int tenthPart = 0;
    int sum = 0;
    for(int i = 0; i<size; i++)
    {
        tenthPart = number - number % 10;
        sum = sum + (number - tenthPart);
        number = number / 10;
    }
    return sum;
}
int sumNumbers = Sumnumbers(number);
Console.WriteLine($"The sum of the numbers of the entered number is equal to: {sumNumbers}");
