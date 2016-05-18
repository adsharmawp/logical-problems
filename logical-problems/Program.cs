using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic;
            // logic = new ValidateBracketsPairInAnExpression();
            logic = new SearchBiggestPalindromeInString();

            Console.WriteLine(logic.InputString);
            var input = Console.ReadLine();
            var result = logic.Run(input);
            Console.WriteLine(string.Format(logic.OutputString, result));

            Console.ReadLine();
        }
    }
}
