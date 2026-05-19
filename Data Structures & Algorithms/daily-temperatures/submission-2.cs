public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new Stack<int>();
        int[] res = new int[temperatures.Length];
        for(int i = 0; i<temperatures.Length; i++){
            while(stack.Count > 0 && temperatures[stack.Peek()] <  temperatures[i]){
                int pos = stack.Pop();
                res[pos] = i - pos;
            }
            stack.Push(i);
        }
        return res;
    }
}
