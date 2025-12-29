public class Solution {
    public bool IsStrobogrammatic(string num) {

        if(num.Length == 1 && !(num == "0" || num == "1" || num == "8")){
            return false;
        }

        Dictionary<int,int> res = new Dictionary<int,int>(){
            {0,0},
            {1,1},
            {6,9},
            {8,8},
            {9,6}
        };

        int left = 0;
        int right = num.Length -1;

        while(right >= left){
            var value = ToInt(num[left]);
            var value2 = ToInt(num[right]);

            if(!(res.ContainsKey(value) || res.ContainsKey(value2))){
                return false;
            }
            if(res[value] == value2){
                right--;
                left++;
                continue;
            }else{
                return false;
            }
        }

        return true;
    }

    public int ToInt(char c)
    {
        return (int)(c - '0');
    }
}