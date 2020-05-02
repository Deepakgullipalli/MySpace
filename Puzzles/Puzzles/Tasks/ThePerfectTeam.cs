using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class ThePerfectTeam
    {
        static int differentTeams(string skills)
        {
            ulong x;
            var charCount = SkillCount(skills);
            if (!charCount.ContainsKey('p') || !charCount.ContainsKey('c') || !charCount.ContainsKey('m')
                || !charCount.ContainsKey('b') || !charCount.ContainsKey('z'))
            {
                return 0;
            }
            else
            {
                 x = charCount.Values.Min();
            }
            foreach (var character in charCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
            return Convert.ToInt32(x);
        }

        public static SortedDictionary<char, ulong> SkillCount(string stringToCount)
        {
            SortedDictionary<char, ulong> characterCount = new SortedDictionary<char, ulong>();

            foreach (var character in stringToCount)
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }

            return characterCount;
        }

        public void ThePerfectTeamMain()
        {
            try
            {
                int res;
                string skills;
                skills = "pcmpcmbbbzz";
                
                res = differentTeams(skills);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
