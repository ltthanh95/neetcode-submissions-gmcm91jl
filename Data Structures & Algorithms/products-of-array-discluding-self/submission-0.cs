public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] arr1 = new int[nums.Length];
        int prod = 1;
        for(int i = 0;i < nums.Length; i++){
            arr1[i] = prod;
            prod *= nums[i];
        }

        int prod2 = 1;
        int[] arr2 = new int[nums.Length];
        for(int i = nums.Length - 1;i >=0; i--){
            arr2[i] = prod2;
            prod2 *= nums[i];
        }

        for(int i = 0;i < nums.Length; i++){
            arr1[i] *= arr2[i];
        }
        return arr1;


    }
}
