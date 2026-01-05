public class Solution {
    public int MaxOperations(int[] nums, int k) {
        Array.Sort(nums);
        int count = 0;
        int i = 0;
        int j = nums.Length - 1;
        int sum = 0;

        while(j > i){
            sum = nums[i] + nums[j];

            if(sum > k){
                sum = 0;
                j--;
            }else if(sum < k){
                sum = 0;
                i++;
            }else{
                count++;
                sum = 0;
                i++;
                j--;
            }
        }

        return count;

    }
}