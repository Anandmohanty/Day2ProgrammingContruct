using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ProgrammingContruct
{
    internal class ForLoop
    {
        public void PowerOf2(int number)
        {
            for(int i =0; i<=number; i++) 
            {
                double result = Math.Pow(2,i);
                Console.WriteLine(result);
            }
        }
    }
}
