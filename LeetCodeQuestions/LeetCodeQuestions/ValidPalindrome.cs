using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions
{
    public class ValidPalindrome
    {
        public bool ValidPalindrome1(string s)
        {
            var charArray = s.ToCharArray();
            var length = charArray.Length;
            var count = 0;
            int mid = 0;
            if (length % 2 == 0)
            {
                mid = length / 2 - 1;
            }
            else
            {
                mid = length / 2;
            }

            for (int i = 0; i <= mid; i++)
            {
                if (mid == 1 && charArray[0] != charArray[mid])
                {
                    count++;
                }

                if (i == mid && s.IndexOf(charArray[i], 0, mid) == -1 && s.IndexOf(charArray[i], mid, charArray.Length - 1 - mid) == -1 && charArray.Length % 2 != 0)
                {
                    count++;
                }

                if (charArray[i] != charArray[length - 1 - i])
                {
                    count++;
                }
            }

            return count <= 1;
        }

        public bool RepeatedSubstringPattern(string s)
        {
            var charArray = s.ToCharArray();
            var patternList = new List<char>();
            var pattern = string.Empty;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (patternList.Contains(charArray[i]) && IsPattern(pattern, s, string.Empty))
                {
                    return true;
                }

                pattern = pattern + charArray[i].ToString();
                patternList.Add(charArray[i]);
            }

            return false;
        }

        public bool IsPattern(string pattern, string target, string sumString)
        {
            if (target.Length % pattern.Length != 0)
            {
                return false;
            }

            if (sumString == target)
            {
                return true;
            }

            if (sumString.Length > target.Length)
            {
                return false;
            }

            sumString = sumString + pattern;
            return IsPattern(pattern, target, sumString);
        }
    }
}
