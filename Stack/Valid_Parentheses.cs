
//Link: https://leetcode.com/problems/valid-parentheses/
public class SolutionValidParentheses {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var bracketDict = new Dictionary<char, char>{{'(',')'}, {'{','}'}, {'[',']'}};

        foreach(char c in s){

            // Check if the current char is a closing bracket
            if (stack.Count != 0 && c == bracketDict[stack.Peek()]){
                stack.Pop();
                continue;
            }

            //Check if it is an opening bracket
            if (bracketDict.ContainsKey(c)){
                stack.Push(c);
            }
            else{
                return false;
            }
            
        }
        return stack.Count == 0;
    }
}