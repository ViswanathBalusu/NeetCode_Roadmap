//Link: https://leetcode.com/problems/min-stack/

//Min Stack implementation using two stacks
public class MinStack
{
    Stack<int> stk;
    Stack<int> minStk;

    public MinStack() {
        this.stk = new Stack<int>();
        this.minStk = new Stack<int>();
    }
    
    public void Push(int val) {
        int prevMin = stk.Count !=0 ? minStk.Peek():int.MaxValue;
        this.minStk.Push(Math.Min(prevMin, val));
        this.stk.Push(val);
    }
    
    public void Pop() {
        this.minStk.Pop();
        this.stk.Pop();
    }
    
    public int Top() {
        return this.stk.Peek();
    }
    
    public int GetMin() {
        return this.minStk.Peek();
    }
}


//Min Stack implementation using a Single List
public class MinStack1 {
    private List<int> lst;

    public MinStack1() {
        this.lst = [];
    }
    
    public void Push(int val) {
        int prevMin = lst.Count !=0 ? lst[lst.Count - 2]:int.MaxValue;
        this.lst.Add(Math.Min(prevMin, val));
        this.lst.Add(val);
    }
    
    public void Pop() {
        this.lst.RemoveAt(lst.Count - 1); // Count is Updated Here
        this.lst.RemoveAt(lst.Count - 1); // Again remove the last element
    }
    
    public int Top() {
        return this.lst[lst.Count - 1];
    }
    
    public int GetMin() {
        return this.lst[lst.Count - 2];
    }
}
