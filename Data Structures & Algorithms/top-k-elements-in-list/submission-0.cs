public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] topKFrequentNumbers = new int[k];
        Dictionary<int, int>freq = new Dictionary<int, int>();

        for(int i = 0; i< nums.Length; i++){
            freq[nums[i]]=freq.GetValueOrDefault(nums[i])+1;
        }

        var sortedFreq = freq.OrderByDescending(x => x.Value).ToList();

        for(int i = 0; i< k; i++){
            topKFrequentNumbers[i] = sortedFreq[i].Key;
        }

        return topKFrequentNumbers;
    }
}