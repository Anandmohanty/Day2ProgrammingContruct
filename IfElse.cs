﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ProgrammingContruct
{
    public class IfElse
    {
        //1.Write a C# Sharp program to accept two integers and check whether
        //they are equal or not.
        public void EqualorNot(int valueOne, int valueTwo)
        {
            if (valueOne == valueTwo)
            {
                Console.WriteLine("Given integers is Equal");
            }
            else
            {
                Console.WriteLine("Given integers is not Equal");
            }
        }

        //Write a C# Sharp program to check whether a given number is even or odd.
        public void EvenOrOdd(int givenData)
        {
            if (givenData % 2 == 0)
            {
                Console.WriteLine("Given Number is Even Number");
            }
            else
            {
                Console.WriteLine("Ggiven Number is Odd Number");
            }
        }
        //  Write a C# Sharp program to read the age of a candidate and
        //determine whether it is eligible for casting his/her own vote.
        public void VotingEligiblity(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are Eligible For Voting ");
            }
            else
            {
                Console.WriteLine("You are age is below 18 so you are Not Eligible For Voting ");
            }
        }

    }
}
