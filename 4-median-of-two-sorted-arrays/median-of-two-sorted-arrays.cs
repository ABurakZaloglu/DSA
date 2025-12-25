public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        //solved
        int i = 0;
        int j = 0;
        double ans = 0;
        List<int> mergedArray = new List<int>();

        while(i < nums1.Length && j < nums2.Length){
            if(nums1[i] < nums2[j]){
                mergedArray.Add(nums1[i]);
                i++;
            }else{
                mergedArray.Add(nums2[j]);
                j++;
            }
        }

        while(j < nums2.Length){
            mergedArray.Add(nums2[j]);
            j++;
        }

        while(i < nums1.Length){
            mergedArray.Add(nums1[i]);
            i++;
        }

        if(mergedArray.Count % 2 == 0){
            ans = (mergedArray[(mergedArray.Count / 2)] + mergedArray[(mergedArray.Count / 2)-1])/2.0;
        }else{
            ans = mergedArray[mergedArray.Count / 2];
        }

        return ans;
    }
}