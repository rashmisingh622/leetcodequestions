using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions
{
    public class CountSegments
    {
        public int CountSegments1(string s)
        {
            var charArray = s.ToCharArray();
            if (charArray.Length == 0)
            {
                return 0;
            }

            var count = 1;
            for (var i = 0; i < charArray.Length;)
            {
                if (charArray[i] == ' ')
                {
                    count++;
                    while (i < charArray.Length && charArray[i] == ' ')
                    {
                        i++;
                    }
                }
                else
                {
                    i++;
                }
            }

            var anyChar = charArray.Any(c => c != ' ');
            if (count > 0 && !anyChar)
            {
                return 0;
            }

            if (count > 0 && charArray[charArray.Length - 1] == ' ' && charArray[0] == ' ')
            {
                return count - 2;
            }

            if (count > 0 && (charArray[charArray.Length - 1] == ' ' || charArray[0] == ' '))
            {
                return count - 1;
            }

            return count;
        }
    }
}
