public class Solution {
    private static Dictionary<int, int> temp;
    private static int Dp(int n, int[] cost){
        if(n <=1){
            return 0;
        }
        if(temp.ContainsKey(n)){
            return temp[n];
        }

        int x = Math.Min(Dp(n - 1, cost) + cost[n - 1], Dp(n - 2, cost) + cost[n-2]);

        temp.Add(n, x);
        return x;
    }
    public int MinCostClimbingStairs(int[] cost) {
        temp =new Dictionary<int, int>();
        return Dp(cost.Length, cost);
    }
}
