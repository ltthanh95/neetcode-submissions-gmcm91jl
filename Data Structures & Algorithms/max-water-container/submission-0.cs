public class Solution {
    public int MaxArea(int[] heights) {
        int area = 0;
        int i= 0;
        int j = heights.Length - 1;
        while(i<j){
            int row = Math.Min(heights[i], heights[j]);
            area = Math.Max(row * (j - i), area);
            if(heights[i] <= heights[j]){
                i+=1;
            }
            else{
                j-=1;
            }
        }
        return area;
    }
}
