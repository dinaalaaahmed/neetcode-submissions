public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int start = 0;
        int end = 0;
        int max = 0;
        HashSet<char> characters = new HashSet<char>();
        while(end < s.Length){
            if(!characters.Contains(s[end])){
                characters.Add(s[end]);
                end++;
            }
            else {
                if(characters.Count > max){
                    max = characters.Count;
                }
                characters.Remove(s[start]);
                start++;
            }
        }

        if(characters.Count > max){
            max = characters.Count;
        }
        return max;
    }
}
