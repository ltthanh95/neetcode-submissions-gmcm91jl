public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0){
            return 0;
        }
        int cnt = 0;
        for(int i = 0; i < nums.Length; i++){
            int res = 0;
            int n = nums[i] - 1;
            if(!nums.Contains(n)){
                while(nums.Contains(n+1)){
                    res+=1;
                    n+=1;
                }
                cnt = Math.Max(res, cnt);
            }
        }
        return cnt;
    }
}
