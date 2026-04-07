public class Solution {
    public bool IsPalindrome(string s) {
        int i=0;
        int j=s.Length - 1;
        char[] arr = s.ToCharArray();
        while(i <= j){
            if(!char.IsLetterOrDigit(arr[i])){
                i+=1;
            }
            else if(!char.IsLetterOrDigit(arr[j])){
                j-=1;
            }
            else{
                if(char.ToLower(arr[i]) != char.ToLower(arr[j])){
                    return false;
                }
                i+=1;
                j-=1;
            }
        }
        return true;
    }
}
