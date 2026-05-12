public class Program
{
    public int MaxScore(int[] cardPoints, int k)
    {
        int windowSum = 0;
        for (var i = 0; i < k; i++)
        {
            windowSum += cardPoints[i];
        }
        int bestSum = windowSum;
        int j = cardPoints.Length - 1;
        for (var i = 1; i <= k; i++)
        {
            windowSum -= cardPoints[k - i];
            windowSum += cardPoints[j];
            j--;
            if (windowSum > bestSum)
            {
                bestSum = windowSum;
            }
        }
        return bestSum;
    }
}





