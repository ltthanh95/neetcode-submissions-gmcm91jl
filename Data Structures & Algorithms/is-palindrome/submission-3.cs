public class Solution {
    public static bool dp(char[] s, int i, int j){
        if(i >= j){
            return true;
        }
        bool result;
        if(!char.IsLetterOrDigit(s[i])){
            result = dp(s, i + 1, j);
        }
        else if(!char.IsLetterOrDigit(s[j])){
            result = dp(s, i, j-1);
        }
        else if(char.ToLower(s[i])!=char.ToLower(s[j])){
            result = false;
        }
        else{
            result = dp(s, i + 1, j - 1);
        }
        
        return result;
    }
    public bool IsPalindrome(string s) {
        char[] arr = s.ToCharArray();
        return dp(arr, 0, arr.Length - 1);
    }
}
