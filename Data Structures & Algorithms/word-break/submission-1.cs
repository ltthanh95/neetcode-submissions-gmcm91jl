public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        HashSet<string> hs = new HashSet<string>(wordDict);
        bool[] dp = new bool[s.Length + 1];
        int maxLength = int.MinValue;
        foreach(var i in hs){
            maxLength = Math.Max(maxLength, i.Length);
        }

        dp[0] = true;
        for(int i = 1; i <= s.Length; i++){
            for(int j = Math.Max(i - maxLength, 0); j < i; j++){
                string temp = s[j..i];
                Console.WriteLine(i+ ": "+ j+ "=>"+ temp);
                if(hs.Contains(temp) && dp[j]){
                    dp[i] = true;
                    break;
                }
            }
        }
        foreach(var i in dp){
            Console.Write(i);
        }
        return dp[s.Length];
    }
}
