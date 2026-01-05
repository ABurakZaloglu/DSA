public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        if(n == 0){
            return true;
        }

        for(int i = 0; i < flowerbed.Length; i++){
            if(flowerbed[i] == 0){
                bool leftisempty = (i == 0 || flowerbed[i-1] == 0);
                bool rightisempty = (i == flowerbed.Length-1 || flowerbed[i+1] == 0);

                if(rightisempty && leftisempty){
                    n--;
                    flowerbed[i] = 1;
                }

                if(n == 0){
                    return true;
                }
            }
        }

        return false;
    }
}