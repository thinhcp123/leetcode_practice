public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
      int counter = 0;
      foreach(int item in arr){
        if(item % 2 != 0){
            counter++;
            if(counter == 3) return true;
        }else{
            counter =0;
        }
      }
      return false;
    }
}