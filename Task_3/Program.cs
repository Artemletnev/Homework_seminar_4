//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Random var

// Console.WriteLine("Enter array size: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[n];
// int 
// for(int i = 0; i < n; i++)
// {
//     array[i] = random.Next(100);
// }
// Console.WriteLine($"[{String.Join(";", array)}]");


// With enter var

Console.WriteLine("Enter array size: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter arrays numbers with ENTER: ");
string[] arrayFromString = new string[n];
for(int i = 0; i < arrayFromString.Length; i++)
{
   arrayFromString[i] = Console.ReadLine();
}
Console.WriteLine($"[{String.Join(";", arrayFromString)}]");











