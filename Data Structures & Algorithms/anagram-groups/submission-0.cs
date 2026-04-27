public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> freq = new Dictionary<string, List<string>>();
        for(int i = 0; i<strs.Length; i++){
            int[] alphabets = new int[26];
            for(int character = 0; character < strs[i].Length; character++){
                alphabets[strs[i][character] - 'a']++;
            }
            var code = string.Join(",", alphabets);
            if(!freq.ContainsKey(code)){
                freq[code] = new List<string>();
            }
            freq[code].Add(strs[i]);
        }

        return freq.Values.ToList();
    }
}