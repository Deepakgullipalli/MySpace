using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class PatternOccurrences
    {
        public int TotalCount(string pattern, string source)
        {
            string result = string.Empty;
            for (int i = 0; i < source.Length; i++)
            {
                result += IsVowel(source[i]) ? "0" : "1";
            }
            int f = CheckOccurrences(result, pattern);
            return f;
        }

        static bool IsVowel(char input)
        {
            return (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u') || (input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U');
        }

        static int CheckOccurrences(string str1, string pattern)
        {
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == pattern[0])
                {
                    count += test(str1.Substring(i, str1.Length - i), pattern);
                }
            }

            return count;
        }
    }
}
