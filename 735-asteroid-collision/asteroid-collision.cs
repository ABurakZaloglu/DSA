public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> myStack = new Stack<int>();

        for(int i = 0; i < asteroids.Length; i++){
            bool flag = true;
            if(asteroids[i] > 0){
                myStack.Push(asteroids[i]);
            }else{
                while(myStack.Count > 0 && myStack.Peek() > 0 &&  asteroids[i] < 0){
                    if(Math.Abs(myStack.Peek()) < Math.Abs(asteroids[i])){
                        myStack.Pop();
                        continue;
                    }else if (Math.Abs(myStack.Peek()) == Math.Abs(asteroids[i])){
                        myStack.Pop();
                    }

                    flag = false;
                    break;
                }

                if(flag){
                    myStack.Push(asteroids[i]);
                }
            }
        }
        
        var res = myStack.ToArray();
        Array.Reverse(res);
        return res;
    }
}