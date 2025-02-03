//Link: https://leetcode.com/problems/two-sum/description/

public class SolutionTwoSum {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i=0; i < nums.Length; i++){
            if( !dict.ContainsKey(nums[i])){
                dict[target-nums[i]] = i;
            }
            else{
                return [i, dict[nums[i]]];
            }
        }
        return null;
    }
}