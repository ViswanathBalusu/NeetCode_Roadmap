//Link: https://leetcode.com/problems/evaluate-reverse-polish-notation/

public enum Operation{
    Divide,
    Multiply,
    Add,
    Substract
}

public class Solution {

    public int EvalRPN(string[] tokens) {
        var stk = new Stack<int>();
        foreach(string s in tokens){
            
            if (s == "+" || s == "-" || s == "*" || s == "/"){
                Operation op = s switch{
                    "+" => Operation.Add,
                    "-" => Operation.Substract,
                    "/" => Operation.Divide,
                    "*" => Operation.Multiply,
                };
                stk.Push(Caluculate(stk.Pop(), stk.Pop(), op));
                continue;
            }
            stk.Push(Int32.Parse(s));
        }
        return stk.Pop();
        
    }

    private int Caluculate(int a, int b, Operation op) => op switch
    {
        Operation.Divide => b / a,
        Operation.Multiply => b * a,
        Operation.Add => b + a,
        Operation.Substract => b - a,
    };
}