public class Solution {
    private static Dictionary<int, int> store;
    public static int dp(int n){
        if(n == 0){
            return 1;
        }
        if(n == 1){
            return 1;
        }
        if(store.ContainsKey(n)){
            return store[n];
        }
        int x = dp(n - 1) + dp(n - 2);
        store.Add(n, x);
        return x;
    }
    public int ClimbStairs(int n) {    
        store = new Dictionary<int, int>();
        return dp(n);
    }
}
