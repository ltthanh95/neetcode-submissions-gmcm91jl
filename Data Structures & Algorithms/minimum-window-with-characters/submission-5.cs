public class Solution {
    public string MinWindow(string s, string t) {
        if(t == ""){
            return "";
        }
        if(s.Length < t.Length){
            return "";
        }
        IDictionary<char, int> TDictionary = new Dictionary<char, int>();
        IDictionary<char, int> SDictionary = new Dictionary<char, int>();
        foreach(var i in t){
            if(TDictionary.ContainsKey(i)){
                TDictionary[i]+=1;
            }
            else{
                TDictionary[i] = 1;
            }
        }

        int j = 0;
        int[] res = new int[] {-1, -1};
        int need = TDictionary.Count;
        int MaxRes = int.MaxValue;
        int have = 0;
        for(int i=0;i<s.Length;i++){
            char c = s[i];
            if(SDictionary.ContainsKey(c)){
                SDictionary[c]+=1;
            }
            else{
                SDictionary[c] = 1;
            }
            if(TDictionary.ContainsKey(c) && SDictionary[c] == TDictionary[c]){
                have+=1;
            }
            while(have==need){
                if(i - j + 1 < MaxRes){
                    MaxRes = i - j +1;
                    res[0]= j;
                    res[1] = i;
                }
                char left = s[j];
                SDictionary[left] -= 1;
                if(TDictionary.ContainsKey(left) && SDictionary[left] < TDictionary[left]){
                    have--;
                }
                j++;
            }

        }
        return MaxRes == int.MaxValue ? "" : s.Substring(res[0], MaxRes);
    }
}
