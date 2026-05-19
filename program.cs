public class Program
{
    private Queue<int> queue = new Queue<int>();
    public MyStack()
    {
    }
    public void Push(int x)
    {
        queue.Enqueue(x);
    }
    public int Pop()
    {
        var newQueue = new Queue<int>();
        var clonedQueue = new Queue<int>(queue);
        var count = queue.Count;
        int lastItem = 0;
        for (var i = 0; i < count; i++)
        {
            int item = clonedQueue.Dequeue();
            if (i == count - 1)
            {
                lastItem = item;
            }
            else
            {
                newQueue.Enqueue(item);
            }
        }
        queue = newQueue;
        return lastItem;
    }
    public int Top()
    {
        var clonedQueue = new Queue<int>(queue);
        var count = queue.Count;
        int top = 0;
        for (var i = 0; i < count; i++)
        {
            int item = clonedQueue.Dequeue();
            if (i == count - 1)
            {
                top = item;
            }
        }
        return top;
    }
    public bool Empty()
    {
        bool isEmpty = queue.Count == 0;
        return isEmpty;
    }
}





