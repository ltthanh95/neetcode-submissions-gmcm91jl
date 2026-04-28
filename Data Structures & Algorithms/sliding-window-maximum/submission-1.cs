public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        PriorityQueue<int, int> pq = new PriorityQueue<int ,int>(
            Comparer<int>.Create((a, b) => b.CompareTo(a))
        );
        int[] res = new int[nums.Length - k + 1];
        for(int i = 0;i < k; i++){
            while(pq.Count > 0 && nums[pq.Peek()] < nums[i]){
                pq.Dequeue();
            }
            pq.Enqueue(i, nums[i]);
        }
        res[0] = nums[pq.Peek()];
        for(int i = k;i<nums.Length;i++){
            if(pq.Peek() <= i - k){
                pq.Dequeue();
            }
            while(pq.Count > 0 && nums[pq.Peek()] < nums[i]){
                pq.Dequeue();
            }
            pq.Enqueue(i, nums[i]);
            if(i >= i-k+1) res[i - k + 1] = nums[pq.Peek()];
        }

        return res;
    }
}
