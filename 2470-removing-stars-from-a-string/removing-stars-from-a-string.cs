public class Solution {
    public string RemoveStars(string s) {
        Stack myStack = new Stack();
        StringBuilder answer = new StringBuilder();
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '*'){
                myStack.Pop();
            }else{
                myStack.Push(s[i]);
            }
        }

        while(myStack.Count != 0){
            answer.Append(myStack.Pop());
        }

        char[] charArray = answer.ToString().ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }
}