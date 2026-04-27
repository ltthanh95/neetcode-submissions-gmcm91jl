public class Solution {
    private static IDictionary<int, int> store;
    private static int dp(int n, int[] nums){
        if(n < 0){
            return 0;
        }
        if(store.ContainsKey(n)){
            return store[n];
        }

        int x = Math.Max(dp(n - 1, nums), dp(n - 2, nums) + nums[n]);

        store[n] = x;
        return x;
    }
    public int Rob(int[] nums) {
        /*
        [1,1,3,3]
        rob(3) = max(rob(1) + cost[3], rob(2))
        => rob(3) = max(1+3, 4) = 4

        rob(1) = Max(1,1) = 1

        rob(2) = max(rob(0) = 1 + cost[2], rob(1) = 1)

        => rob(2) = max(1 + 3, 1) = 4

        rob(0) = 1

        rob(1) = Max(1, 1) = 1

        -----------
        call rob(3)
        */
        store = new Dictionary<int, int>();
        return dp(nums.Length - 1, nums);
    }
}
