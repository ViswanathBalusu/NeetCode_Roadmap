//Link: https://leetcode.com/problems/remove-duplicates-from-sorted-array/submissions/1529281162/

namespace LeetCodeHunt.AlgorithmsandDataStructuresforBeginners.StaticArrays
{
    public class SolutionStaticArrays
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int i = 0;

            for (int j = 1;  j < nums.Length; j++)
            {
                    if (nums[i] != nums[j])
                    {
                        i++;
                        nums[i] = nums[j];
                    }

            }
            return i + 1;
        }
    }
}