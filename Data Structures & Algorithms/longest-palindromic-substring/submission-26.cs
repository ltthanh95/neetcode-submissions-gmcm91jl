public class Solution {
    private static IDictionary<string, bool> store;

    private static bool Dp(int i, int j, string s) {
        if (i >= j) {
            return true;
        }

        string key = i + "," + j;

        if (store.ContainsKey(key)) {
            return store[key];
        }

        bool c;

        if (s[i] != s[j]) {
            c = false;
        } else {
            c = Dp(i + 1, j - 1, s);
        }

        store[key] = c;
        return c;
    }

    public string LongestPalindrome(string s) {
        if(s.Length == 1){
            return s[0].ToString();
        }
        store = new Dictionary<string, bool>();
        string res = "";

        for(int i = 0;i<s.Length - 1; i++){
            for(int j = i; j<s.Length; j++){
                if(Dp(i, j, s)){
                    if(j - i + 1> res.Length){
                        res = s.Substring(i, j - i + 1);
                    }
                }
            }
        }

        return res;
    }
}