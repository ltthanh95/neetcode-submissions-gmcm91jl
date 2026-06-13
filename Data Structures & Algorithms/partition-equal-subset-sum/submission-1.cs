public class Solution {
    private static IDictionary<(int, int), bool> store;
    private static bool dp(int i, int[] nums, int s){
        if(s == 0){
            return true;
        }
        if(i < 0 || s < 0){
            return false;
        }

        if(store.ContainsKey((i, s))){
            return store[(i, s)];
        }

        bool take = dp(i - 1, nums, s - nums[i]);
        bool skip = dp(i - 1, nums, s);

        store[(i, s)] = take || skip;

        return take || skip;
    }
    public bool CanPartition(int[] nums) {
        //state: at current index i and remaining sum, can I reach to target with current sum?
        int totalSum = nums.Sum();
        if(totalSum % 2 != 0){
            return false;
        }
        store = new Dictionary<(int, int), bool>();
        int target = totalSum / 2;
        return dp(nums.Length - 1, nums, target);
        
    }
}
