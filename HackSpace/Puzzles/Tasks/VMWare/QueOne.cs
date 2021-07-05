using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.VMWare
{
    public class QueOne
    {
        public void QueOneMain()
        {
            string excelCellColumn = GetExcelColumnName(730);
            int rowNumber = GetExcelRowNumber(730);

            String[] words = { "a", "b", "ba", "bca", "bda", "bdca" };
            int chain = longestChain(words);
            Console.WriteLine("longestChain " + chain);
        }

        private int GetExcelRowNumber(int v)
        {
            if(v % 702 == 0)
            {
                return v / 702;
            }
            int val = v / 702;
            return val + 1;
        }

        private static string GetExcelColumnName(long columnNumber)
        {
            long dividend = columnNumber;
            string columnName = String.Empty;
            long modulo;
            int count = 0;
            while (dividend > 0)
            {
                if (count < 2)
                {
                    modulo = (dividend - 1) % 26;
                    columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                    dividend = (int)((dividend - modulo) / 26);
                    count++;
                }
                else
                {
                    modulo = (dividend - 1) % 26;
                    columnName = Convert.ToChar(65 + modulo).ToString();
                    dividend = (int)((dividend - modulo) / 26);
                }
            }

            return columnName;
        }


        static int longestChain(String[] words)
        {
            List<String> wordList = words.ToList();
            int max = Int32.MinValue;

            foreach (var word in words)
            {
                int current = processWord(word, wordList);
                if (max < current)
                {
                    max = current;
                }
                Console.WriteLine(current);
            }

            return max;
        }

        static int processWord(String word, List<String> allWords)
        {
            if (word.Length == 1)
                return 1;

            Stack<String> wordsStack = new Stack<String>();
            wordsStack.Push(word);

            // start and end indices which hold character is dropped from the current word
            int startIndex = 0;
            int endIndex = 1;

            while (!(wordsStack.Count == 0))
            {
                String currentWord = wordsStack.Peek();

                if (endIndex > currentWord.Length)
                {
                    break;
                }

                if (allWords.Contains(currentWord))
                {
                    StringBuilder wordBuilder = new StringBuilder(currentWord);
                    wordBuilder.Remove(startIndex, endIndex);
                    wordsStack.Push(wordBuilder.ToString());
                }
                else
                {
                    wordsStack.Pop();
                    startIndex++;
                    endIndex++;
                }
            }

            return wordsStack.Count();
        }

        /*
         


class Result {


        public static int longestChain(List<String> words)
        {
            int max = Integer.MIN_VALUE;
            String[] strArr = new String[words.size()];
            strArr = words.toArray(strArr);
            for (String word:words)
            {
                int curr = findNextWord(strArr, word, 0);
                max = Math.max(max, curr);
            }
            return max;
        }
        static int maxStack = 0;

        static int findNextWord(String[] words, String word, int stack)
        {

            if (!contains(words, word))
            {
                return 0;
            }
            stack++;
            maxStack = stack;
            System.out.println("1 stack " + stack + " maxStack " + maxStack);
            for (int i = 0; i < word.length(); i++)
            {
                StringBuilder sb = new StringBuilder(word);
                sb.delete(i, i + 1);
                findNextWord(words, sb.toString(), stack);
            }
            System.out.println("2 stack " + stack + " maxStack " + maxStack);

            return maxStack;
        }

        static boolean contains(String[] words, String wordToSearch)
        {
            for (String currentWord : words)
            {
                if (currentWord.equals(wordToSearch))
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class Solution
    {
         */
    }
}
