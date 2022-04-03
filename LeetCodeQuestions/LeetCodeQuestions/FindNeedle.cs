namespace LeetCodeQuestions
{
    public  static class FindNeedle
    {
        public static int StrStr(string haystack, string needle)
        {
            var source = haystack.ToCharArray();
            var needleArray = needle.ToCharArray();

            if (needleArray.Length == 0)
            {
                return 0;
            }

            for (int j = 0; j < source.Length;)
            {
                var i = 0;
                var initialJ = j;
                if (source[j] == needleArray[i])
                {
                    while (j < source.Length && i < needleArray.Length && source[j] == needleArray[i])
                    {
                        j++;
                        i++;
                    }

                    if (i == needleArray.Length)
                    {
                        return initialJ;
                    }
                    else
                    {
                        j = initialJ;
                    }
                }

                j++;
            }

            return -1;
        }
    }
}
