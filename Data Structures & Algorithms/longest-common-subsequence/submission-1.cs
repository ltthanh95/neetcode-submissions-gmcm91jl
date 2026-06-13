public class Solution {
    private static IDictionary<(int, int), int> store;
    private int dp(int i, int j, string text1, string text2){
        if(i < 0 || j < 0){
            return 0;
        }
        if(store.ContainsKey((i, j))){
            return store[(i, j)];
        }
        if(text1[i] == text2[j]){
            int x = 1 + dp(i - 1, j - 1, text1, text2);
            store[(i, j)] = x;
        }
        else{
            int x = Math.Max(dp(i - 1, j, text1, text2), dp(i, j - 1, text1, text2));
            store[(i, j)] = x;
        }
        return store[(i, j)];
    }
    public int LongestCommonSubsequence(string text1, string text2) {
        store = new Dictionary<(int, int), int>();
        return dp(text1.Length - 1, text2.Length - 1, text1, text2);
    }
}
