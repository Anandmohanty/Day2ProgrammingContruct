using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ProgrammingContruct
{
    public class ForLoop
    {
        public void PowerOf2(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);

                //Write a program that reads a number N and prints the sum of squares of N numbers starting from 1.

                void SumOfSquare(int number)
                {
                    int sum = 0;
                    for (int i = 1; i <= number; i++)
                    {
                        sum += i * i;
                    }
                }
            }
        }
    }
}

