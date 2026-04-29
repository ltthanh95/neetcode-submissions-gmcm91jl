public class Solution {
    public bool IsValid(string s) {
        Stack<char> store = new Stack<char>();
        foreach(var i in s){
            if(i == '(' || i == '[' || i == '{'){
                store.Push(i);
            }
            else{
                if(i == ')'){
                    if(store.Count > 0 && store.Peek() == '('){
                        store.Pop();
                    }
                    else{
                        return false;
                    }
                }
                else if(i == ']'){
                    if(store.Count > 0 && store.Peek() == '['){
                        store.Pop();
                    }
                    else{
                        return false;
                    }
                }
                else if(i == '}'){
                    if(store.Count > 0 && store.Peek() == '{'){
                        store.Pop();
                    }
                    else{
                        return false;
                    }
                }
            }
        }
        return store.Count == 0 ? true: false;
    }
}
