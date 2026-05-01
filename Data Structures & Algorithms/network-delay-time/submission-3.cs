public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        List<Tuple<int, int>>[] toNodes = new List<Tuple<int, int>>[n];
        PriorityQueue<int, int> q = new PriorityQueue<int, int>();
        q.Enqueue(k-1, 0);
        int[] distances = new int[n];
        for(int i = 0; i < n; i++){
            toNodes[i] = new List<Tuple<int, int>>();
            distances[i] = int.MaxValue;
        }

        foreach(var edge in times){
            toNodes[edge[0]-1].Add(new(edge[1]-1, edge[2]));
        }

        distances[k-1] = 0;
    
        while(q.Count != 0){
            q.TryDequeue(out int node, out int distance);
            if(distances[node] < distance) continue;

            foreach(var toNode in toNodes[node]){
                if(distances[node] + toNode.Item2 < distances[toNode.Item1]){
                    distances[toNode.Item1] = distances[node] + toNode.Item2;
                    q.Enqueue(toNode.Item1, distances[toNode.Item1]);
                }
            }
        }

        int max = 0;
        for(int i = 0; i < n; i++){
            max = Math.Max(max, distances[i]);
            if(distances[i] == int.MaxValue) return -1;
        }

        return max;
    }
}
