public class Solution 
{
    public int EvalRPN(string[] tokens) 
    {
        var stk = new Stack<int>();
        
        foreach(var token in tokens)
        {
            int num1, num2 = 0;
            switch(token)
            {
                case "+":
                    num1 = stk.Pop();
                    num2 = stk.Pop();
                    stk.Push(num2 + num1);
                    break;
                case "-":
                    num1 = stk.Pop();
                    num2 = stk.Pop();
                    stk.Push(num2 - num1);
                    break;
                case "*":
                    num1 = stk.Pop();
                    num2 = stk.Pop();
                    stk.Push(num2 * num1);
                    break;
                case "/":
                    num1 = stk.Pop();
                    num2 = stk.Pop();
                    stk.Push(num2 / num1);
                    break;
                default:
                    stk.Push(int.Parse(token));
                    break;
            }
        }
        
        return stk.Pop();
    }
}