public class Arrays
{

    public int RemoveDuplicates(int[] nums)
    {
    }

    public int RemoveElement(int[] nums, int val)
    {
    }

    public int[] TwoSum(int[] nums, int target)
    {
    }

    public int[] GetConcatenation(int[] nums)
    {
    }

    public int[] RunningSum(int[] nums)
    {
    }

    public int MaximumWealth(int[][] accounts)
    {
    }
}

public class HashingArrays
{

    public bool ContainsDuplicate(int[] nums)
    {
    }
}


public class ArrayTwoPointers
{
}


public class Stacks
{

    public bool IsValid(string s)
    {
    }

    public int CalPoints(string[] operations)
    {
        var stack = new Stack<int>();
        for (var i = 0; i < operations.Length; i++)
        {
            if (int.TryParse(operations[i], out int number))
            {
                stack.Push(number);
            }
            else if (operations[i] == "C")
            {
                stack.Pop();
            }
            else if (operations[i] == "D")
            {
                var prevScore = stack.Peek();
                var doubledScore = prevScore * 2;
                stack.Push(doubledScore);
            }
            else if (operations[i] == "+")
            {
                var prevScore = stack.Pop();
                var secondPrevScore = stack.Peek();
                var sum = prevScore + secondPrevScore;
                stack.Push(prevScore);
                stack.Push(sum);
            }
        }

        int pointsTotal = 0;
        if (stack.Count != 0)
        {
            foreach (var item in stack)
            {
                pointsTotal += item;
            }
        }
        return pointsTotal;
    }
}










