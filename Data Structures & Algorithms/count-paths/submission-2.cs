public class Solution {
    private static IDictionary<(int, int), int> store;
    private static bool CheckBoundary(int i, int j, int m, int n){
        return (i >= 0 && i < m) && (j >= 0 && i < n);
    }
    private static int dfs(int i, int j, int m, int n){
        if(i > m || j > n){
            return 0;
        }
        if(i == m - 1 && j == n - 1){
            return 1;
        }
        if(store.ContainsKey((i, j))){
            return store[(i, j)];
        }
        int down = dfs(i + 1, j, m, n);
        int right = dfs(i , j + 1, m, n);
        int x = down + right;
        store[(i, j)] = x;
        return x;
    }
    public int UniquePaths(int m, int n) {
        // state: how many numbers possible unique paths at index i and j

        store = new Dictionary<(int, int), int>();

        return dfs(0, 0, m, n);
        
    }
}
