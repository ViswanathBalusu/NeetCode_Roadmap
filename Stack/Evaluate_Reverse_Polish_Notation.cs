//Link: https://leetcode.com/problems/evaluate-reverse-polish-notation/

public enum ArthimeticOperation
{
    Divide,
    Multiply,
    Add,
    Substract
}

public class SolutionEvaluateReversePolishNotation {

    public int EvalRPN(string[] tokens) {
        var stk = new Stack<int>();
        foreach(string s in tokens){
            
            if (s == "+" || s == "-" || s == "*" || s == "/"){
                ArthimeticOperation op = s switch{
                    "+" => ArthimeticOperation.Add,
                    "-" => ArthimeticOperation.Substract,
                    "/" => ArthimeticOperation.Divide,
                    "*" => ArthimeticOperation.Multiply,
                };
                stk.Push(Calculate(stk.Pop(), stk.Pop(), op));
                continue;
            }
            stk.Push(Int32.Parse(s));
        }
        return stk.Pop();
        
    }

    private int Calculate(int a, int b, ArthimeticOperation op) => op switch
    {
        ArthimeticOperation.Divide => b / a,
        ArthimeticOperation.Multiply => b * a,
        ArthimeticOperation.Add => b + a,
        ArthimeticOperation.Substract => b - a,
        _ => throw new NotImplementedException(),
    };
}