public class Solution {
    private static IDictionary<int, int> store1;
    private static IDictionary<int, int> store2;
    private static int Dp(int i, int[] nums, IDictionary<int, int> store){
        if(i < 0){
            return 0;
        }

        if(store.ContainsKey(i)){
            return store[i];
        }
        int x = Math.Max(Dp(i - 1, nums, store), Dp(i - 2, nums, store) + nums[i]);
        store[i] = x;
        return x;
    }
    public int Rob(int[] nums) {
        if(nums.Length == 1){
            return nums[0];
        }
        store1 = new Dictionary<int, int>();
        store2 = new Dictionary<int, int>();
        int x = Dp(nums[0..(nums.Length - 1)].Length - 1, nums[0..(nums.Length - 1)], store1);
        int y = Dp(nums[1..].Length - 1, nums[1..], store2);
        return Math.Max(x, y);
    }
}
