public class Program
{
    public void MoveZeroes(int[] nums)
    {
        int k = 0;
        bool emptySlot = false;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0 && !emptySlot)
            {
                k = i;
                emptySlot = true;
            }
            else if (nums[i] != 0 && emptySlot)
            {
                nums[k] = nums[i];
                nums[i] = 0;
                if (nums[k + 1] == 0)
                {
                    k = k + 1;
                }
                else
                {
                    k = i;
                }
            }
        }
    }
}





