//Link: https://leetcode.com/problems/top-k-frequent-elements/


//Time Complexity O(n) + O(n) + O(n) = O(n)
//Space: O(n) + O(n)
public class SolutionTopKFrequentElements {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        foreach (int val in nums)
        {
            dict[val] = 1 + (dict.ContainsKey(val) ? dict[val] : 0);
        }


        List<int>[] cnts = new List<int>[nums.Length];

        foreach (int val in dict.Keys)
        {
            if (cnts[dict[val] - 1] == null)
            {
                cnts[dict[val] - 1] = new List<int>();
            }
            cnts[dict[val] - 1].Add(val);
        }

        var topK = new List<int>(k);

        for (int i = nums.Length; i > 0; i--)
        {
            if (cnts[i-1] != null)
            {
                foreach (int j in cnts[i-1])
                {
                    topK.Add(j);
                    if (topK.Count == k)
                    {
                        return topK.ToArray();
                    }
                }
            }

        }
        return null;

    }
}



//Priority Queue Implementation
//Time Complexity : O(n) + O(log(n))
//Space Complexity: O(n) + O(n)
public class SolutionTopKElements2 {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        foreach (int val in nums)
        {
            dict[val] = 1 + (dict.ContainsKey(val) ? dict[val] : 0);
        }


        var pq = new PriorityQueue<int, int>();
        foreach (var key in dict.Keys)
        {
            pq.Enqueue(key, dict[key]);
            if (pq.Count > k) pq.Dequeue();
        }
        int k1 = k;
        int[] arr = new int[k1];
        while (pq.Count > 0) {
            arr[--k1] = pq.Dequeue();
        }
        return arr;
    }
}