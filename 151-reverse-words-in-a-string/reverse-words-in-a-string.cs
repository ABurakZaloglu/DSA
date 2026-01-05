public class Solution {
    public string ReverseWords(string s) {
        string[] temp = s.Split(" ");
        string res = "";

        for(int i = temp.Length -1; i >= 0; i--){
            if(temp[i] == ""){
                continue;
            }
            if(res == ""){
                res = temp[i].Trim();
            }else{
                res += " " +temp[i].Trim();
            }
            
        }

        return res;
    }
}