public class Solution {
    private static IDictionary<(int, int), int> store;
    private static int dp(int amount, int i, int[] coins){
        if(amount == 0){
            return 1;
        }
        if(amount < 0 || i >= coins.Length){
            return 0;
        }
        if(store.ContainsKey((i, amount))){
            return store[(i, amount)];
        }
        int res = 0;
        int skip = dp(amount, i+1, coins);

        int take = dp(amount - coins[i], i, coins);
        res = skip + take;
        store[(i, amount)] = res;
        return res;
    }
    public int Change(int amount, int[] coins) {
        //state: how we count distinct number way to get total upto current amount 
        store = new Dictionary<(int, int), int>();
        return dp(amount, 0 ,coins);
    }
}
