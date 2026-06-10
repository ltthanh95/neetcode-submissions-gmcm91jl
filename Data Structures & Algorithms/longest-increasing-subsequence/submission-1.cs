public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] dp = new int[nums.Length + 1];
        for(int i = 0; i < dp.Length; i++){
            dp[i] = 1;
        }
        for(int i = 0; i<nums.Length; i++){
            for(int j = 0; j<i; j++){
                if(nums[j] < nums[i]){
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }
        foreach(var i in dp){
            Console.Write(i + " ");
        }
        return dp.Max();
    }
}
