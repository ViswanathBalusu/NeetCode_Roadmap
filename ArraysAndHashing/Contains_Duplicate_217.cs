// Link: https://leetcode.com/problems/contains-duplicate/description/

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> unique = new HashSet<int>();
        foreach(int i in nums){
            if (unique.Contains(i)){
                return true;
            }
            unique.Add(i);
        }
        return false;
    }
}