public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if(hand.Length%groupSize!=0)return false;
        Array.Sort(hand);
        Dictionary<int, int> freq = new Dictionary<int, int>();
        int number = 0;
        for(int i = 0; i<hand.Length;i++){
            freq[hand[i]]=freq.GetValueOrDefault(hand[i])+1;
        }

        for(int i = 0; i<hand.Length;i++){
            if(freq[hand[i]]==0) continue;

            for(int j = 0; j<groupSize; j++){
                number = hand[i]+j;
                if(!freq.ContainsKey(number)||freq[number]==0){
                    return false;
                }
                freq[number]--;
            }
        }
        return true;

    }
}
