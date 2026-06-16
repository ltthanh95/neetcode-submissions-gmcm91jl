public class Solution {
    private static IDictionary<(int, int), int> store;
    private static int dp(int i, int remain ,int target, int[] nums){
        if(i == nums.Length){
            return remain == target ? 1 : 0;
        }
        if(store.ContainsKey((i, remain))){
            return store[(i, remain)];
        }
        int res = 0;
        int add = dp(i + 1, remain + nums[i], target, nums);
        int minus = dp(i + 1, remain - nums[i], target, nums);
        res = add + minus;
        store[(i, remain)] = res;
        return res;

    }
    public int FindTargetSumWays(int[] nums, int target) {
        
        store = new Dictionary<(int, int), int>();
        return dp(0, 0, target, nums);
    }
}
