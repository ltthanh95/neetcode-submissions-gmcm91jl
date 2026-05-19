public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] temp = new int[position.Length][];
        for(int i = 0;i<position.Length;i++){
            temp[i]=new int[] {position[i], speed[i]};
        }
        Array.Sort(temp, (a, b) => b[0].CompareTo(a[0]));
        //Console.WriteLine(temp[0][0] + " "+ temp[0][1]);
        Stack<double> stack = new Stack<double>();
        int cnt = 0;
        for(int i = 0; i<temp.Length; i++){
            double hrs = (double)(target - temp[i][0]) / temp[i][1];

            if(stack.Count <= 0 || stack.Peek() < hrs){
                stack.Push(hrs);
            }
            
            
        }
        return stack.Count;
    }
}
