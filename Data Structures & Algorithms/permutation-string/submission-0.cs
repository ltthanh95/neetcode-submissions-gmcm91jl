public class Solution {
    public static bool Check(Dictionary<char, int> dictionary, string s1){
        Dictionary<char, int> store = new Dictionary<char, int>();
        for(int i=0; i<s1.Length; i++){
            if(!store.ContainsKey(s1[i])){
                store.Add(s1[i], 1);
            }
            else{
                store[s1[i]]+=1;
            }
        }
        foreach(var i in store.Keys){
            if(!dictionary.ContainsKey(i) || store[i] != dictionary[i]){
                return false;
            }
        }
        return true;
    }
    public bool CheckInclusion(string s1, string s2) {
        int len1 = s1.Length;
        int len2 = s2.Length;
        if(len1>len2){
            return false;
        }
        Dictionary<char, int> store = new Dictionary<char, int>();
        for(int i=0; i<len1; i++){
            if(!store.ContainsKey(s1[i])){
                store.Add(s1[i], 1);
            }
            else{
                store[s1[i]]+=1;
            }
        }

        int j = 0;

        for(int i = 0; i < s2.Length; i++){
            while(i - j + 1>len1){
                 
                j++;
            }
            if(Check(store, s2.Substring(j, len1))){
                return true;
            } 
        }
        return false;
    }
}
