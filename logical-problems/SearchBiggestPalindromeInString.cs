using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_problems
{
    public class SearchBiggestPalindromeInString : Logic
    {
        // Input: 'nitinspeaksmalayalam' || Output: 'malayalam'
        // Input: 'nitinsalas'           || Output: 'nitin,salas'
        public SearchBiggestPalindromeInString()
        {
            this.InputString = "Enter string to search biggest palindrome (Ex: nitinspeaksmalayalam):";
            this.OutputString = "Biggest palindrome: {0}";
        }

        public override string Run(string inputString)
        {
            List<string> biggestPalindromeStringList = new List<string>();
            if (string.IsNullOrEmpty(inputString)) return string.Empty;
            
            int inputStringLength = inputString.Length;

            // start search with biggest character set to lower character set for optimized search
            for (int i = inputStringLength; i > 0; i--)
            {
                string subString = inputString.Substring(0, i);
                if (subString == Reverse(subString))
                    biggestPalindromeStringList.Add(subString);

                // search for inner character sets
                for (int startIndex = 1; startIndex <= inputStringLength - i; startIndex++)
                {
                    subString = inputString.Substring(startIndex, i);
                    if (subString == Reverse(subString))
                        biggestPalindromeStringList.Add(subString);
                }

                if (biggestPalindromeStringList.Count > 0)
                    break;
            }

            // concatenate same size palindrome strings
            return string.Join(",", biggestPalindromeStringList);
        }

        // String reverse function
        private string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
