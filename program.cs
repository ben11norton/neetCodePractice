public class Program
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int k = 0;
        for (var i = m; i < m + n; i++)
        {
            nums1[i] = nums2[k];
            k++;
        }
        for (var i = 0; i < m + n; i++)
        {
            for (var j = 0; j < m + n; j++)
            {
                if (nums1[i] < nums1[j])
                {
                    var temp = nums1[i];
                    nums1[i] = nums1[j];
                    nums1[j] = temp;
                }
            }
        }
    }
}





