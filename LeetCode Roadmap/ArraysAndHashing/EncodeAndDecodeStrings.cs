//Link: https://leetcode.com/problems/encode-and-decode-strings/

//AltLink: https://neetcode.io/problems/string-encode-and-decode

using System.Text;

public class SolutionEncodeAndDecodeStrings {

    public string Encode(IList<string> strs)
    {
        var strBuilder = new StringBuilder();
        foreach (string s in strs)
        {
            // base64 conversion to make sure the input words dont have '#' and also induce more randomness into the encoded string
            // Base64 encoded strings only have (A–Z, a–z), the numerals (0–9), and the "+", "=" and "/" symbols.
            string b64Str = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
            strBuilder.Append($"{b64Str.Length.ToString()}#{b64Str}");
        }
        return strBuilder.ToString();
    }

    public List<string> Decode(string s)
    {
        var decodedString = new List<string>();
        int i = 0;
        int j = 0;
        while (i < s.Length)
        {
            
            if (s[j] != '#')
            {
                j++;
                continue;
            }
            int wordSize = Int32.Parse(s.Substring(i, j-i));
            string word = Encoding.UTF8.GetString(Convert.FromBase64String(s.Substring(j + 1, wordSize)));
            decodedString.Add(word);
            i = j + wordSize + 1;
            j = i;
        }
        return decodedString;
    }
}

