public class Solution {
    private static Dictionary<int, int> store;
    private static int Dp(string s, int i){
        if(i == 0){
            return 1;
        }
        if(i == 1){
            return s[i - 1] == '0' ? 0 : 1;
        }
        if(store.ContainsKey(i)){
            return store[i];
        }
        int res = 0;
        Console.WriteLine(s.Substring(i - 1, 1));
        if(int.Parse(s.Substring(i - 1, 1))>=1 &&  int.Parse(s.Substring(i - 1, 1))<10){
            res += Dp(s, i - 1);
        }
        if(int.Parse(s.Substring(i - 2, 2))>=10 &&  int.Parse(s.Substring(i - 2, 2))<=26){
            res += Dp(s, i - 2);
        }
        store[i] = res;
        return res;
    }
    public int NumDecodings(string s) {
        store = new Dictionary<int, int>();
        return Dp(s, s.Length);


    }
}
