namespace SquareApp
{   
    internal class Program
    {
        static int Square(int number) => number * number;
        static void Main(string[] args)
        {
            int number = 10;
            int result = Square(number);
            Console.WriteLine($"{number} * {number} = {result}");
        }
    }
}