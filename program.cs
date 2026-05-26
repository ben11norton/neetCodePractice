public class Program
{
    public void MoveZeroes(int[] nums)
    {
        int k = 0;
        bool zeroeSlot = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0 && zeroeSlot)
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
            else if (nums[i] == 0 && !zeroeSlot)
            {
                zeroeSlot = true;
                k = i;
            }
        }
    }
}





