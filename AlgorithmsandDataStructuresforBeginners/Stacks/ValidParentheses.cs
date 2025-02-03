//Link: https://leetcode.com/problems/valid-parentheses/submissions/1529327942/

namespace LeetCodeHunt.AlgorithmsandDataStructuresforBeginners.Stacks
{
    public class SolutionValidParentheses
    {
        public bool IsValid(string s)
        {
            var mapping = new Dictionary<char, char>() { { '{', '}' }, { '[', ']' }, { '(', ')' } };
            var stk = new Stack<char>();

            foreach(var c in s)
            {

                if (stk.Count != 0 && c == mapping[stk.Peek()])
                {
                    stk.Pop();
                    continue;
                }

                if (mapping.ContainsKey(c))
                {
                    stk.Push(c);
                }
                else
                {
                    return false;
                }

            }
            return stk.Count == 0;
        }
    }
}
