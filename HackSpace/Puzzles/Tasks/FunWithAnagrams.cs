using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class FunWithAnagrams
    {
        public void FunWithAnagramsMain()
        {
            //List<string> anaList = new List<string> { "poke", "pkoe", "okpe", "ekop" };
            List<string> anaList = new List<string> { "code", "aaagmnrs", "anagrams", "doce" };
            funWithAnagrams(anaList);
        }
        public List<string> funWithAnagrams(List<string> s)
        {
            Dictionary<string, string> anaDict = new Dictionary<string, string>();
            foreach (var item in s)
            {
                char[] charArr = item.ToLower().ToCharArray();
                
                Array.Sort(charArr);
                
                string sortedWord = new string(charArr);


                string anaKey;
                if (anaDict.TryGetValue(sortedWord,out anaKey))
                {
                    continue;
                }
                anaDict[sortedWord] = item;
            }
            var stringList = anaDict.Values.OrderBy(n=>n).ToList();
            return new List<string>();
        }
    }
}
