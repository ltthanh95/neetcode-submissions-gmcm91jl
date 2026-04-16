public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res = 0;
        int j = 0;
        int freqMax = 0;
        Dictionary<char, int> store = new Dictionary<char, int>();
        for(int i=0;i<s.Length;i++){
            if(!store.ContainsKey(s[i])){
                store.Add(s[i], 1);
            }
            else{
                store[s[i]]+=1;
            }
            freqMax = Math.Max(freqMax, store[s[i]]);
            while((i - j + 1) - freqMax > k){
                store[s[j]] -=1;
                //freqMax = Math.Max(freqMax, store[s[j]]);
                j+=1;

            }
            res=Math.Max(res, i - j + 1);
            
        }
        return res;
    }
}
