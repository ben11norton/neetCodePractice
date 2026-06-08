public class Program
{
    public int MaxScore(int[] cardPoints, int k)
    {
        int score = 0;
        for (var i = 0; i < k; i++)
        {
            score += cardPoints[i];
        }
        int maxScore = score;
        int pointer = 1;
        while (pointer <= k)
        {
            score -= cardPoints[k - pointer];
            score += cardPoints[cardPoints.Length - pointer];
            pointer++;
            if (score > maxScore)
            {
                maxScore = score;
            }
        }
        return maxScore;
    }
}





