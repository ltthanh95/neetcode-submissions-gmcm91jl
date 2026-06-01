public class Solution {
    private static Dictionary<int, int> store;
    private static int Dp(int[] coins, int amount){
        if(amount <= 0){
            return 0;
        }
        if(store.ContainsKey(amount)){
            return store[amount];
        }

        int c = int.MaxValue;
        foreach(var i in coins){
            int x = 0;
            if(i <= amount){
                x = Dp(coins, amount - i);
                if(x != int.MaxValue){
                    c = Math.Min(x + 1, c);
                }
                
            }
            Console.WriteLine("else: "+ x + " " + amount);
        }
        Console.WriteLine("out: "+ c + " " + amount);
        store[amount] = c;
        return c;

    }
    public int CoinChange(int[] coins, int amount) {
        store = new Dictionary<int, int>();
        return Dp(coins, amount) == int.MaxValue ? -1 : Dp(coins, amount);
    }
}
