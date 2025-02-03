//Link: https://leetcode.com/problems/group-anagrams/

public class SolutionGroupAnagrams {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new();

        foreach (string s in strs){
        	char[] hash = new char[26];
        	foreach (char c in s){
        		hash[c - 'a']++;
        	}

        	string key = new string(hash);

            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }
            dict[key].Add(s);
        }
        return dict.Values.ToList();
    }
}