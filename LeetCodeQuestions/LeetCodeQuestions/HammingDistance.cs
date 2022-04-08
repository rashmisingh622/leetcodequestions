namespace LeetCodeQuestions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class HammingDistance
    {
        public static int HammingDistance1(int x, int y)
        {
            var binary1 = ConvertToBinary(x);
            var binary2 = ConvertToBinary(y);
            var hammingDistance = 0;
            var zeros = string.Empty;
            var difference = Math.Abs(binary1.Length - binary2.Length);
            if (binary1.Length > binary2.Length)
            {
                for (int i = 0; i < difference; i++)
                {
                    zeros += "0";
                }

                binary2 = zeros + binary2;
            }

            if (binary2.Length > binary1.Length)
            {
                for (int i = 0; i < difference; i++)
                {
                    zeros += "0";
                }

                binary1 = zeros + binary1;
            }

            for (int i = 0; i < binary1.Length; i++)
            {
                if (binary1[i] != binary2[i])
                {
                    hammingDistance++;
                }
            }

            return hammingDistance;
        }

        public static string ConvertToBinary(int num)
        {
            var result = string.Empty;
            while (num >= 1)
            {
                result = num % 2 + result;
                num /= 2;
            }

            return result;
        }
    }
}
