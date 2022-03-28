namespace LeetCodeQuestions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GetTarget
    {
        public bool Search(int[] nums, int target)
        {
            if (nums.Length == 1 && nums[0] == target)
            {
                return true;
            }

            for (int i = 0; i < nums.Length;)
            {
                if (target == nums[i])
                {
                    return true;
                }
                else if (i < nums.Length && target > nums[i])
                {
                    i++;
                    continue;
                }
                else if (target < nums[i])
                {
                    while (i < nums.Length - 1 && nums[i + 1] > nums[i])
                    {
                        i += 1;
                    }

                    i += 1;
                }
            }

            return false;
        }
    }
}
