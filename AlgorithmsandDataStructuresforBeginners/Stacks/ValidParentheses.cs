//Link: https://leetcode.com/problems/valid-parentheses/submissions/1529327942/
//Link 2: https://leetcode.com/problems/valid-parentheses/submissions/1530428200/

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

    public class SolutionValidParentheses2
    {
        public bool IsValid(string s)
        {
            var top = -1;

            var stk = new char[s.Length];

            foreach (var c in s) {
                if (c == '{' || c == '[' || c == '(')
                {
                    stk[++top] = c;
                    continue;
                }

                if (top == -1)
                {
                    return false;
                }

                var peek = stk[top];
                if ((c == '}' && peek == '{') ||
                    (c == ']' && peek == '[') ||
                    (c == ')' && peek == '('))
                {
                    top--;
                }
                else
                {
                    return false;
                }

            }
            return top == -1;
        }
    }
}
