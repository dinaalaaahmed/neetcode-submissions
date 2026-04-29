public class Solution {
    public List<List<int>> sol = new List<List<int>>();
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        SubsetsWithDupBackTrack(nums, 0, new List<int>());
        return sol;
    }

    public void SubsetsWithDupBackTrack(int[] nums, int index, List<int> curr) {
        sol.Add(new List<int>(curr));

        for(int i = index; i< nums.Length; i++){
            if(i > index && nums[i] == nums[i-1]) continue;
            curr.Add(nums[i]);
            SubsetsWithDupBackTrack(nums, i+1, curr);
            curr.RemoveAt(curr.Count-1);
        }
    }
}
