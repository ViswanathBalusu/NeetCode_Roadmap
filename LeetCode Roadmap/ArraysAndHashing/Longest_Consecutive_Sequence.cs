//Iteraring the nums array will encounter duplicates and redo the same stuff again and again
public class SolutionLongestConsecutiveSequence {
    public static int LongestConsecutive(int[] nums) {
        var hs = new HashSet<int>(nums);

        int longest = 0;

        for (int i=0; i<nums.Length; i++){
            if (hs.Contains(nums[i] - 1)){
                continue;
            }
            int length = 0;
            while(hs.Contains(nums[i]+length)){
                length++;
            }
            if (length > longest){
                longest = length;
            }
        }
        return longest;
    }
}


// More  Optimzed way is to Iterate the Hashset that is created i.e avoiding duplicates
public class SolutionLongestConsecutiveSequence1 {
    public int LongestConsecutive(int[] nums) {
        var hs = new HashSet<int>(nums);

        int longest = 0;

        foreach(int i in hs){
            if(!hs.Contains(i-1)){
                int length = 0;
                while(hs.Contains(i+length)){
                    length++;
                    longest = Math.Max(longest, length);
                }
            }
        }
        return longest;
    }
}