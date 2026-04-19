public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] store1 = new int[26];
        int[] store2 = new int[26];
        for(int i = 0; i<s1.Length; i++){
            store1[s1[i] - 'a']++;
        }
        int j = 0;
        for(int i = 0; i<s2.Length; i++){
            store2[s2[i] - 'a']++;
            while(i - j + 1>s1.Length){
                store2[s2[j] - 'a']--;
                j++;
            }
            if(Match(store1, store2)){
                return true;
            }
           
        }
        return false;
    }
    public static bool Match(int[] s1, int[] s2){
        for(int i = 0; i<26; i++){
            if(s1[i] != s2[i]){
                return false;
            }
        }
        return true;
    }
}
