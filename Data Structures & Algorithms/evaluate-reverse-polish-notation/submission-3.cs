public class Solution {
    Stack<int> stack;
    public int SCase(string operation, int a, int b){
        if(operation == "+"){
            return a+b;
        }
        else if(operation == "-"){
            return a-b;
        }
        else if(operation == "*"){
            return a*b;
        }
        else{
            if(b!=0){
                return a / b;
            }
        }
        return 0;
    }
    public int EvalRPN(string[] tokens) {
        stack = new Stack<int>();
        foreach(var x in tokens){
            if(int.TryParse(x, out int result)){
                stack.Push(result);
            }
            else{
                if(stack.Count() > 1){
                    int n1 = stack.Pop();
                    int n2 = stack.Pop();
                    Console.WriteLine(n1 + " " + n2+ "=>"+SCase(x, n2, n1));
                    stack.Push(SCase(x, n2, n1));
                }
            }
        }
        return stack.Peek();
    }
    
}
