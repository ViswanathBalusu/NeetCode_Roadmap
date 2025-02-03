//Link: https://leetcode.com/problems/product-of-array-except-self/

public class SolutionProductOfArrayExceptSelf {
    public int[] ProductExceptSelf(int[] nums) {
        var arr = new int[nums.Length];
        arr[0] = 1;

        for(int i = 1; i<nums.Length; i++){
            arr[i] = arr[i-1]*nums[i-1];
        }

        int postfix = 1;

        for(int i = nums.Length-1; i>=0; i--){
            arr[i] *= postfix;
            postfix *= nums[i]; 
        }
        return arr;
    }
}