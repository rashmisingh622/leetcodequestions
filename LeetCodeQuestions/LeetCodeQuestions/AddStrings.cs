namespace LeetCodeQuestions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    internal class AddStrings
    {
        public string AddStrings1(string num1, string num2)
        {
            var length1 = num1.Length;
            var length2 = num2.Length;
            if (length1 > length2)
            {
                return GetSum(num1, num2).ToString();
            }
            else if (length1 == length2)
            {
                return GetSumEqualDigits(num1, num2);
            }
            else
            {
                return GetSum(num2, num1);
            }
        }

        public string GetSum(string num1, string num2)
        {
            var carry = 0;
            var sum = string.Empty;
            var length1 = num1.Length;
            var length2 = num2.Length;
            var charArray1 = num1.ToCharArray();
            var diff = length1 - length2;
            var newArray = new char[length1];
            for (int i = 0; i < length1; i++)
            {
                if (i < diff)
                {
                    newArray[i] = '0';
                }
                else
                {
                    newArray[i] = num2[i - diff];
                }
            }

            var counter = 0;
            for (int i = length1 - 1; i >= 0; i--)
            {
                var sumDigits = Convert.ToInt32(charArray1[i].ToString()) + Convert.ToInt32(newArray[i].ToString()) + carry;
                if (sumDigits > 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                sum = (sumDigits % 10).ToString() + sum;
                counter++;
            }

            if (carry == 1)
            {
                sum = "1" + sum;
            }

            return sum;
        }

        public string GetSumEqualDigits(string num1, string num2)
        {
            var charArray1 = num1.ToCharArray();
            var charArray2 = num2.ToCharArray();
            var carry = 0;
            var sum = string.Empty;
            var length1 = num1.Length;
            var length2 = num2.Length;

            var counter = 0;
            for (int i = length1 - 1; i >= 0; i--)
            {
                var sumDigits = Convert.ToInt32(charArray1[i].ToString()) + Convert.ToInt32(charArray2[i].ToString()) + carry;
                if (sumDigits > 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                sum = (sumDigits % 10).ToString() + sum;
                counter++;
            }

            if (carry == 1)
            {
                sum = "1" + sum;
            }

            return sum;
        }
    }
}
