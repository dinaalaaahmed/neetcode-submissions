public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int arraySum = nums[0];

        for(int i = 1;i < nums.Length ; i++){
          arraySum = Math.Max(nums[i], arraySum+nums[i]);
          if(arraySum > maxSum){
            maxSum = arraySum;
          }
        }
        

        return maxSum;
    }
}
