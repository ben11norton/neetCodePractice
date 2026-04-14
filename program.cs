public class Program
{
    public int[] SortedSquares(int[] nums)
    {
        var l = 0;
        var r = nums.Length - 1;
        int p = r;
        var sqrNums = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            var lSqrd = nums[l] * nums[l];
            var rSqrd = nums[r] * nums[r];
            if (lSqrd > rSqrd)
            {
                sqrNums[p] = lSqrd;
                l++;
                p--;
            }
            else
            {
                sqrNums[p] = rSqrd;
                r--;
                p--;
            }
        }
        return sqrNums;
    }
}
