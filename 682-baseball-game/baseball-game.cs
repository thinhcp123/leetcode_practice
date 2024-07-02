public class Solution {
    public int CalPoints(string[] operations) {
        var scores= new Stack<int>();

        foreach(string operation in operations){
            switch(operation){
                case "+":
                {
                    int lastScore = scores.Pop();
                    int newScore = scores.Peek() + lastScore;

                    scores.Push(lastScore);
                    scores.Push(newScore);
                    break;
                }
                case "D":
                {
                    int newScore = scores.Peek() * 2;
                    scores.Push(newScore);
                    break;
                } 
                case "C":
                {
                    scores.Pop();
                    break;
                }
                default:
                {
                    int num =  int.Parse(operation);
                    scores.Push(num);
                    break;
                }
            }
        }

        return scores.Sum();
    }
}