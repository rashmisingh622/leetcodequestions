namespace LeetCodeQuestions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SearchTargetInArray
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 2)
            {
                if (nums[0] == target)
                {
                    return 0;
                }
                else if (nums[1] == target)
                {
                    return 1;
                }
            }

            return SearchTarget(nums, 0, nums.Length - 1, target);
        }

        public int SearchTarget(int[] nums, int start, int end, int target)
        {
            var mid = (int)Math.Floor((decimal)(start + end) / 2);

            if (mid == 0 && nums[mid] != target && nums[end] != target)
            {
                return -1;
            }

            if (mid == nums.Length - 1 && nums[mid] != target)
            {
                return -1;
            }

            if (nums[mid] == target)
            {
                return mid;
            }

            else if (nums[mid] > target)
            {
                return SearchTarget(nums, start, mid - 1, target);
            }
            else if (nums[mid] < target)
            {
                return SearchTarget(nums, mid + 1, nums.Length - 1, target);
            }

            return -1;
        }
    }
}
