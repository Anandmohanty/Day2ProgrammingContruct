﻿namespace Day2ProgrammingContruct
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

            ifElse.EvenOrOdd(valueOne);

            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            ifElse.VotingEligiblity(age);

            Console.WriteLine("Enter first number ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number ");
            int numThree = Convert.ToInt32(Console.ReadLine());
            ifElse.LargeNumber(numOne, numTwo, numThree);


        }
    }
}