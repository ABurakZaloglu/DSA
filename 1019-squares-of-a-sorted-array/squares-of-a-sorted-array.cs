public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] result = new int[nums.Length];
        int i = 0;
        int j = nums.Length-1;

        for (int k = (nums.Length-1); k >= 0; k--)
        {
            if (Math.Pow(nums[i],2) > Math.Pow(nums[j], 2))
            {
                result[k] = nums[i] * nums[i];
                i++;
            }
            else
            {
                result[k] = nums[j] * nums[j];
                j--;
            }
        }

        return result;
    }
}