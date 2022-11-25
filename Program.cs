// Tevfik Hacihamdioglu

// I've experienced functional programming in Javascript and Typescript back then so that I used lambda expression in C#. 

// Program will be executed in this area

class Program
{
    static void Main(string[] args)
    {
        List<int> randomizedList = new List<int>()
        {
               3, 4, 13, 21, 321, 55, 653, 543, 66, 32, 23
        };

        Console.WriteLine("Sorted List: ");
        // Sort the array
        List<int> sortedList = Maths.Sort(randomizedList);

        // I could've used foreach or vanilla for loop. Since I know them so well, I wanted to use LINQ
        sortedList.ForEach(Console.WriteLine);

        Console.WriteLine();

        // Min 
        Console.WriteLine($"Min of two numbers: {Maths.Min(16, 6)}");

        // Max
        Console.WriteLine($"Max of two numbers: {Maths.Max(35, 98)}");

        // Factorial
        Console.WriteLine($"Factorial of 5 is {Maths.Factorial(5)}"); // output will be 120

        Console.ReadKey(true);
    }
}