public class Solution {
    public int LongestSubarray(int[] nums) {
        int res = 0;
        bool flag = false;
        if(!nums.Contains(0)){
            return nums.Length -1;
        }

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0){
                continue;
            }
            for(int j = (i+1); j <= nums.Length; j++){
                if(j == nums.Length){
                    if(flag){
                        res = Math.Max(res, ((j-1)-i));
                    }else{
                        res = Math.Max(res, (j-i));
                    }
                    
                }else{
                    if(nums[j] == 1){
                        continue;
                    }else{
                        if(flag){
                            res = Math.Max(res, (j-1-i));
                            break;
                        }else{
                            flag = true;
                        }
                    }
                }
            }
            
            flag = false;
        }

        return res;
    }
}