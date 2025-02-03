// Link:

namespace LeetCodeHunt.AlgorithmsandDataStructuresforBeginners.DynamicArrays
{
    public class SolutionConcatenationOfArray
    {
        public int[] GetConcatenation(int[] nums)
        {
            var n = nums.Length;
            var ans = new int[ n * 2];

            for (int i = 0; i < n; i++)
            {
                ans[i] = nums[i];
                ans[i + n] = nums[i];
            }
            //GC.Collect();
            return ans;
        }
    }
}
