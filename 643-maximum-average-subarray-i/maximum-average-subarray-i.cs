public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int sum = nums.Take(k).Sum();
        int currentSum = sum;
        for(int i = k; i < nums.Length; i++){
            currentSum += (nums[i] - nums[i-k]);
            if(currentSum > sum){
                sum = currentSum;
            }
        }
        
        return sum / (double)k;
    }
}