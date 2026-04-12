public class Solution {
    public int Trap(int[] height) {
        int i = 0;
        int res = 0;
        Stack<int> s= new Stack<int>();
        while(i < height.Length){
            while(s.Count!=0 && height[s.Peek()] <= height[i]){
                int mid = height[s.Pop()];
                if(s.Count>0){
                    int left = height[s.Peek()];
                    int h = Math.Min(height[i], left) - mid;
                    int w = i - s.Peek() - 1;
                    res += h * w;
                }
                
            }
            s.Push(i);
            i+=1;
        }
        return res;
    }
}
