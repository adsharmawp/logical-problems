using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_problems
{
    // input: [{()}] output: true
    // input: [{(}]  output: false
    public class ValidateBracketsPairInAnExpression : Logic
    {
        public ValidateBracketsPairInAnExpression()
        {
            this.InputString = "Enter string to Validate brackets pairs:";
            this.OutputString = "Brackets pairs are valid: {0}";
        }

        public override string Run(string expressionString)
        {
            Dictionary<char, char> brakets = new Dictionary<char, char>();
            brakets.Add(']', '[');
            brakets.Add('}', '{');
            brakets.Add(')', '(');

            Stack<char> pairsStack = new Stack<char>();

            foreach (char ch in expressionString.ToCharArray())
            {
                if (brakets.ContainsValue(ch))
                {
                    pairsStack.Push(ch);
                }
                else if (brakets.ContainsKey(ch))
                {
                    if (pairsStack.Count > 0 && pairsStack.Peek() == brakets[ch])
                        pairsStack.Pop();
                    else
                        return false.ToString();
                }
            }

            return (pairsStack.Count == 0).ToString();
        }
    }
}
