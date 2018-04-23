using System;
using Bcr.Fractions;

namespace Bcr.Fractions.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(Expression.Evaluate(Console.ReadLine()));
            }
        }
    }
}
