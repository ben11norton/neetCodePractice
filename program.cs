public class Program
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var stack = new Stack<int>();
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums2.Length; i++)
        {
            while (stack.Count > 0 && nums2[i] > stack.Peek())
            {
                map[stack.Pop()] = nums2[i];
            }
            stack.Push(nums2[i]);
        }
        var ans = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            if (map.ContainsKey(nums1[i]))
            {
                ans[i] = map[nums1[i]];
            }
            else
            {
                ans[i] = -1;
            }
        }
        return ans;
    }
}





