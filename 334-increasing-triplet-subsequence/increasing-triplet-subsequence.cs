public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int first_num = Int32.MaxValue;
        int second_num = Int32.MaxValue;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] <= first_num){
                first_num = nums[i];
            }else if(nums[i] <= second_num){
                second_num = nums[i];
            }else{
                return true;
            }
        }

        return false;
    }
}