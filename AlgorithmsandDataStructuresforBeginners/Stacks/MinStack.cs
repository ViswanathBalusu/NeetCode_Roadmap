//Link: https://leetcode.com/problems/min-stack/submissions/1530441903/
//Link: https://leetcode.com/problems/min-stack/submissions/1530444301/ - Best in memory

namespace LeetCodeHunt.AlgorithmsandDataStructuresforBeginners.Stacks
{
    public class MinStack
    {
        private readonly List<int> _minStack = [];

        public MinStack()
        {

        }

        public void Push(int val)
        {
            if (_minStack.Count == 0) 
            {
                _minStack.Add(val);
            }
            else
            {
                _minStack.Add(Math.Min(_minStack[_minStack.Count - 2], val));
            }
            _minStack.Add(val);
        }

        public void Pop()
        {
            _minStack.RemoveAt(_minStack.Count - 1);
            _minStack.RemoveAt(_minStack.Count - 1);
        }

        public int Top()
        {
            return _minStack[_minStack.Count - 1];
        }

        public int GetMin()
        {
            return _minStack[_minStack.Count - 2];
        }
    }
}
