public class Solution {
    public int Jump(int[] nums) {
        int[] jumpCounts = new int[nums.Length];
        for(int i=0; i< nums.Length; i++){
            int numberOfJumps = nums[i];
            if(i+numberOfJumps >= nums.Length){
                numberOfJumps=nums.Length-1-i;
            }
            while(numberOfJumps > 0 && i+numberOfJumps < nums.Length){
                if(jumpCounts[i+numberOfJumps] == 0)
                {
                    jumpCounts[i+numberOfJumps]=jumpCounts[i]+1;
                }
                if(jumpCounts[i+numberOfJumps] == nums.Length-1){
                    return jumpCounts[i+numberOfJumps];
                }
                numberOfJumps--;
            }
        }
        return jumpCounts[nums.Length-1];

    }
}
