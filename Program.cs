Console.WriteLine("C# Loops!");
Console.WriteLine("Printing pairs between two numbers\n");
// { o }
Console.WriteLine("Enter the first number: ");
int firstNumber = Int32.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter the second number: ");
int secondNumber = Int32.Parse(Console.ReadLine() ?? "1000");

for (int i = firstNumber; i <= secondNumber; i++)
{
    if (i % 2 == 0)
  {
    Console.WriteLine(i);
  }
}

Console.WriteLine("\nEnd of program....");