using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_problems
{
    // Input: [{()}] || Output: true
    // Input: [{(}]  || Output: false
    public class ValidateBracketsPairInAnExpression : Logic
    {
        public ValidateBracketsPairInAnExpression()
        {
            this.InputString = "Enter string to Validate brackets pairs:";
            this.OutputString = "Brackets pairs are valid: {0}";
        }

        public override string Run(string expressionString)
        {
            Dictionary<char, char> brackets = new Dictionary<char, char>();
            brackets.Add(']', '[');
            brackets.Add('}', '{');
            brackets.Add(')', '(');

            Stack<char> pairsStack = new Stack<char>();

            foreach (char ch in expressionString.ToCharArray())
            {
                if (brackets.ContainsValue(ch))
                {
                    pairsStack.Push(ch);
                }
                else if (brackets.ContainsKey(ch))
                {
                    if (pairsStack.Count > 0 && pairsStack.Peek() == brackets[ch])
                        pairsStack.Pop();
                    else
                        return false.ToString();
                }
            }

            return (pairsStack.Count == 0).ToString();
        }
    }
}
