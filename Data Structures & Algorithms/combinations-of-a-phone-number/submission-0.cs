public class Solution {
    public Dictionary<char, string> numberToCharacters = new Dictionary<char, string>(){
            { '2', "abc"},
            { '3', "def"},
            { '4', "ghi"},
            { '5', "jkl"},
            { '6', "mno"},
            { '7', "pqrs"},
            { '8', "tuv"},
            { '9', "wxyz"},
    };
    public List<string> result = new List<string>();
    public List<string> LetterCombinations(string digits) {
        
        if(digits.Length == 0) return result;
        LetterCombinationsBackTrack(digits, "", 0);
        return result;
    }

    public void LetterCombinationsBackTrack(string digits, string current, int currIndex) {
        if(current.Length == digits.Length){
            result.Add(current);
            return;
        }
        string characters = numberToCharacters[digits[currIndex]];
        for(int j = 0; j < characters.Length; j++){
            current+= numberToCharacters[digits[currIndex]][j];
            LetterCombinationsBackTrack(digits, current, currIndex+1);
            current = current.Remove(current.Length-1);
        }
    }
}
