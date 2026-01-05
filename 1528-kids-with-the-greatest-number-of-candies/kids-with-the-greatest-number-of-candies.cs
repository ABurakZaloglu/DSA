public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = -1;
        bool[] res = new bool[candies.Length];
        for(int i = 0; i < candies.Length; i++){
            if(candies[i] > max){
                max = candies[i];
            }
        }

        for(int i = 0; i < candies.Length; i++){
            if((candies[i] + extraCandies) >= max){
                res[i] = true;
            }else{
                res[i] = false;
            }
        }

        return res;
    }
}