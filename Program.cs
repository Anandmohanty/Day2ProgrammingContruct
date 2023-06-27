namespace Day2ProgrammingContruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Programming Construct");
            IfElse ifElse = new IfElse();
            Console.WriteLine("Enter First value");
            int valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value");
            int valueTwo = Convert.ToInt32(Console.ReadLine());
            ifElse.EqualorNot(valueOne, valueTwo);

        }
    }
}