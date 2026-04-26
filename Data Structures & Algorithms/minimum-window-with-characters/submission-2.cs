public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length < t.Length){
            return "";
        }
        IDictionary<char, int> TDictionary = new Dictionary<char, int>();
       
        foreach(var i in t){
            if(TDictionary.ContainsKey(i)){
                TDictionary[i]+=1;
            }
            else{
                TDictionary.Add(i, 1);
            }
        }
        int[] res = new int[] {-1, -1};
        int MaxRes = int.MaxValue;
        for(int i=0;i<s.Length;i++){
            IDictionary<char, int> SDictionary = new Dictionary<char, int>();
            for(int j = i;j<s.Length;j++){
                if (SDictionary.ContainsKey(s[j])) {
                    SDictionary[s[j]]++;
                } else {
                    SDictionary[s[j]] = 1;
                }

                bool flag = true;
                foreach(var k in TDictionary.Keys){
                    if(!SDictionary.ContainsKey(k) || TDictionary[k] > SDictionary[k]){
                        flag = false;
                        break;
                    }
                }

                if(flag && (j - i + 1) < MaxRes){
                    MaxRes = (j - i + 1);
                    res[0] = i;
                    res[1] = j;
                }
                
            }


        }

        
        return MaxRes == int.MaxValue ? "" : s.Substring(res[0], MaxRes);
    }
}
