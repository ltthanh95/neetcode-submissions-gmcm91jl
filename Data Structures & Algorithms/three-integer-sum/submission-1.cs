public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        Array.Sort(nums);

        for(int i = 0 ;i<nums.Length; i++){
            if(nums[i]>0){
                break;
            }
            if(i>0 && nums[i] == nums[i-1]){
                continue;
            }
            int target = 0 - nums[i];
            
            int s = i+1;
            int e = nums.Length - 1;
            while(s<e){
                if(nums[s] + nums[e] == target){
                    res.Add(new List<int>{nums[i], nums[s], nums[e]});
                    s+=1;
                    e-=1;
                    while(s<e && nums[s] == nums[s - 1]){
                        s+=1;
                    }
                }
                else if(nums[s] + nums[e] > target){
                    e-=1;
                }
                else{
                    s+=1;
                }
            }
            
        }
        return res;
    }
}
