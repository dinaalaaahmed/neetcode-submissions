public class Solution {
    public int MaxArea(int[] heights) {
        int startIndex = 0;
        int lastIndex = heights.Length - 1;
        int maxArea = -1;
        while (lastIndex > startIndex){
            int area = (lastIndex-startIndex)*Math.Min(heights[startIndex], heights[lastIndex]);
            if(area > maxArea){
                maxArea = area;
            }
            if(heights[startIndex] < heights[lastIndex]){
                startIndex++;
            }
            else {
                lastIndex--;
            }
        }
        return maxArea;
    }
}
