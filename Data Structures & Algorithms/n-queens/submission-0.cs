public class Solution {
    List<List<string>> sol = new List<List<string>>();
    public List<List<string>> SolveNQueens(int n) {
        SolveNQueensBackTrack(n, new List<Tuple<int, int>>(), 0);
        return sol;
    }

    public void SolveNQueensBackTrack(int n, List<Tuple<int, int>> currQueenPlaces, int row) {
        if(currQueenPlaces.Count == n){
            sol.Add(convertQueenPlacesToList(n, currQueenPlaces));
            return;
        }
        for(int j = 0; j < n; j++){
            if(!GoodQueenPlace(row, j, currQueenPlaces)) continue;
            currQueenPlaces.Add(new Tuple<int, int>(row, j));
            SolveNQueensBackTrack(n, currQueenPlaces, row+1);
            currQueenPlaces.RemoveAt(currQueenPlaces.Count-1);
        }
    }

    public bool GoodQueenPlace(int row, int col, List<Tuple<int, int>> currQueenPlaces){
        for(int i = 0; i < currQueenPlaces.Count; i++){
            var tuple = currQueenPlaces[i];
            if(tuple.Item1 == row) return false;
            if(tuple.Item2 == col) return false;
            if(Math.Abs(col-tuple.Item2) == Math.Abs(row-tuple.Item1)) return false;
        }
        return true;
    }

    public List<string> convertQueenPlacesToList(int n, List<Tuple<int, int>> currQueenPlaces){
        string[] board = new string[n];
        for(int i = 0; i< currQueenPlaces.Count; i++){
            var tuple = currQueenPlaces[i];
            char[] row = new string('.', n).ToCharArray();
            row[tuple.Item2] = 'Q';
            board[tuple.Item1] = new string(row);
        }
        return board.ToList();
    }
}
