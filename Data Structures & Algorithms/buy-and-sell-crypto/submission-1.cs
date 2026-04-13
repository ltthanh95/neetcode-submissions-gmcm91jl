public class Solution {
    public int MaxProfit(int[] prices) {
        int res = 0;
        int min = prices[0];
        for(int i = 1; i<prices.Length;i++){
            if(prices[i]>min){
                res = Math.Max(res, (prices[i] - min));
            }
            else{
                min = Math.Min(prices[i], min);
            }
        }
        return res;
    }
}
