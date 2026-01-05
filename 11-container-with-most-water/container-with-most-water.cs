public class Solution {
    public int MaxArea(int[] height) {
        int maxarea = 0;
        int left = 0;
        int right = height.Length -1;
        
        while(left < right){
            int width = right-left;
            maxarea = Math.Max(maxarea,(Math.Min(height[left],height[right]) * width));
            
            
            if(height[left] > height[right]){
                right--;
            }else{
                left++;
            }
        }

        return maxarea;
    }
}