public class Solution {
    List<List<string>> sol = new List<List<string>>();
    public List<List<string>> Partition(string s) {
        PartitionBackTrack(s, new List<string>(), 0);
        return sol;
    }

    public void PartitionBackTrack(string s, List<string> curr, int start) {
        if(start == s.Length){
            sol.Add(new List<string>(curr));
            return;
        }
        for(int i = start; i < s.Length; i++){
            string cut = s.Substring(start, i-start+1);
            if(!IsPalandirone(cut) || cut == "") continue;
            curr.Add(cut);
            PartitionBackTrack(s, curr, i+1);
            curr.RemoveAt(curr.Count-1);
        }
    }

    public bool IsPalandirone(string s){
        int start = 0;
        int end = s.Length -1;
        while(end > start){
            if(s[end]==s[start]){
                end--;
                start++;
            }
            else{
                return false;
            }
        }
        return true;
    }
}
