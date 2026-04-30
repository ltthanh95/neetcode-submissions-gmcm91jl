public class Solution {
    private static bool CheckPalindromic(string s){
        int i = 0;
        int j = s.Length - 1;
        while(i < j){
            if(!s[i].Equals(s[j])){
                return false;
            }
            i+=1;
            j-=1;

        }
        return true;
    }
    public string LongestPalindrome(string s) {

        if(s.Length == 1){
            return s[0].ToString();
        }
        string res = "";

        //i is length 
        // j max length of string will check
        for(int i = 1;i<=s.Length;i++){
            int j = s.Length - i + 1;
            for(int k = 0; k+i<=s.Length; k++){
                if(CheckPalindromic(s.Substring(k, i))){
                    if(s.Substring(k, i).Length > res.Length){
                        res = s.Substring(k, i);
                    }
                }
                
            }
        }
        
        return res;
    }
}
