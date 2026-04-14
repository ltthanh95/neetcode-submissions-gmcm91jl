public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int j = 0;
        HashSet<char> set = new HashSet<char>();
        int res = 0;
        for(int i = 0; i < s.Length; i++){
            while(set.Contains(s[i])){
                
                set.Remove(s[j]);
                j+=1;
                
            }
            res = Math.Max(res, i - j + 1);
            set.Add(s[i]);
        }
        return res;
    }
}
