public class Program
{
    public int ThirdMax(int[] nums)
    {
        int? max = null;
        int? secondMax = null;
        int? thirdMax = null;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == max || nums[i] == secondMax || nums[i] == thirdMax)
            {
                // skip duplicate numbers
            }
            else if (max == null || nums[i] > max)
            {
                thirdMax = secondMax;
                secondMax = max;
                max = nums[i];
            }
            else if (secondMax == null || nums[i] > secondMax)
            {
                thirdMax = secondMax;
                secondMax = nums[i];
            }
            else if (thirdMax == null || nums[i] > thirdMax)
            {
                thirdMax = nums[i];
            }
        }
        return thirdMax != null ? (int)thirdMax : (int)max;
    }
}





