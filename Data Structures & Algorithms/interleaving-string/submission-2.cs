public class Solution {
    private static IDictionary<(int, int, int), bool> memo;
    private static bool dp(int i, int j, int k, string s1, string s2, string s3){
        if(i == s1.Length && j == s2.Length && k == i + j){
            return true;
        }
        if(memo.ContainsKey((i, j, k))){
            return memo[(i, j, k)];
        }
        bool s13 = false;
        bool s23 = false;
        if(i < s1.Length && s1[i] == s3[k]){
            s13 = dp(i+1, j, k+1, s1, s2, s3);
        }
        if(j < s2.Length && s2[j] == s3[k]){
            s23 = dp(i, j+1, k+1, s1, s2, s3);
        }
        memo[(i, j, k)] = s13 || s23;
        return s13 || s23;
        

    }
    public bool IsInterleave(string s1, string s2, string s3) {
        if(s1.Length + s2.Length != s3.Length){
            return false;
        }
        memo = new Dictionary<(int, int, int), bool>();
        return dp(0, 0, 0, s1, s2, s3);
    }
}
