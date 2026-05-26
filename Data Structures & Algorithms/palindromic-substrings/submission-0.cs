public class Solution {
    public int CountSubstrings(string s) {
        bool[,] dp = new bool[s.Length, s.Length];
        int res = 0;
        for(int i = s.Length - 1; i>=0; i--){
            for(int j = i; j<s.Length; j++){
                if(s[i] == s[j] && (j - i <=2 || dp[i+1, j-1])){
                    dp[i,j] =true;
                    res+=1;
                }
            }
        }
        return res;
    }
}
