public class Solution {
    public int CharacterReplacement(string s, int k) {
        int start = 0;
        int end = 0;
        int max = 0;
        int maxFreq = 0;
        Dictionary<char, int> freq = new Dictionary<char, int>();
        while(end < s.Length){
            freq[s[end]]=freq.GetValueOrDefault(s[end])+1;
            maxFreq = Math.Max(maxFreq, freq[s[end]]);
            if(end-start+1-maxFreq>k) {
                freq[s[start]]--;
                start++;
            }
            max = Math.Max(max, end-start+1);
            end++;
        }
        return max;
    }
}
