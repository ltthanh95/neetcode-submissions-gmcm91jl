public class MinStack {

    Stack<int> min;
    Stack<int> stack;

    public MinStack() {
        min = new Stack<int>();
        stack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(min.Count > 0){
            min.Push(Math.Min(val,min.Peek()));
        }
        else{
            min.Push(val);
        } 
    }
    
    public void Pop() {
        stack.Pop();
        min.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return min.Peek();
    }
}
