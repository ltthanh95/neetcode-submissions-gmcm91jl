public class Solution {
    private static IDictionary<(int, bool), int> store;
    private static int dp(int i, int[] nums, bool holding){
        if(i >= nums.Length){
            return 0;
        }
        if(store.ContainsKey((i, holding))){
            return store[(i, holding)];
        }
        
        int x = 0;
        int y = 0;
        if(holding){
            int sell = dp(i + 2, nums, false) + nums[i];
            int skip = dp(i + 1, nums, true);
            x = Math.Max(sell, skip);
        }
        else{
            int buy = dp(i + 1, nums, true) - nums[i];
            int skip = dp(i + 1, nums, false);
            y = Math.Max(buy, skip);
        }
        Console.WriteLine(x+" "+y);
        int res = Math.Max(x,y);
        store[(i, holding)]= res;
        return res;
    }
    public int MaxProfit(int[] prices) {
        //state: buy sell skip. at the index i we will 
        //buy: dp(i + 1) - nums[i], 
        //sell: dp(i+1) + nums[i], dp(i+1)
        //skip: dp(i+1)

        store = new Dictionary<(int, bool), int>();
        return dp(0, prices, false);


    }
}
