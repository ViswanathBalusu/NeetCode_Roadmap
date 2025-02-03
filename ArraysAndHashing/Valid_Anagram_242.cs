//LINK: https://leetcode.com/problems/valid-anagram/description/

public class SolutionValidAnagram {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }
        if (s == t) return true;

        Dictionary<char, int> dictS = new Dictionary<char, int>();
        Dictionary<char, int> dictT = new Dictionary<char, int>();

        for (int i=0; i<s.Length; i++){
            dictS[s[i]] = 1 + (dictS.ContainsKey(s[i]) ? dictS[s[i]] : 0);
            dictT[t[i]] = 1 + (dictT.ContainsKey(t[i]) ? dictT[t[i]] : 0);
        }

        foreach (char c in dictS.Keys){
            int tCount = dictT.ContainsKey(c)?dictT[c]:0;
            if (dictS[c] != tCount){
                return false;
            }
            
        }
        return true;
    }
}