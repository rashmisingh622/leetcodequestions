namespace LeetCodeQuestions
{
    using System;
    using System.Linq;

    public class ReverseVowelsOfString
    {
        public string ReverseVowels(string s)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var charArray = s.ToCharArray();
            int lastSwapped = charArray.Length;
            var result = string.Empty;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (vowels.Contains(charArray[i]))
                {
                    if (i >= lastSwapped)
                    {
                        break;
                    }

                    var index = FindVowelFromLeft(charArray, i, lastSwapped - 1, vowels);
                    if (index < 0)
                    {
                        break;
                    }

                    lastSwapped = index;
                    var temp = charArray[i];
                    charArray[i] = charArray[index];
                    charArray[index] = temp;
                }
            }

            return new string(charArray); ;
        }

        public int FindVowelFromLeft(char[] arr, int start, int end, char[] vowels)
        {
            for (int i = end; i > start; i--)
            {
                if (vowels.Contains(arr[i]))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
