public class MedianFinder
{
    PriorityQueue<int, int> biggerNumbers;
    PriorityQueue<int, int> smallerNumbers;

    public MedianFinder()
    {
        biggerNumbers = new ();
        smallerNumbers = new ();
    }

    public void AddNum(int num)
    {
        if (biggerNumbers.TryPeek(out int bigElement, out int bigPriority) && bigPriority < num)
        {
            biggerNumbers.Enqueue(num, num);
        }
        else
        {
            smallerNumbers.Enqueue(num, -num);
        }

        if (smallerNumbers.Count > biggerNumbers.Count + 1)
        {
            var element = smallerNumbers.Dequeue();
            biggerNumbers.Enqueue(element, element);
        }

        if (biggerNumbers.Count > smallerNumbers.Count)
        {
            var element = biggerNumbers.Dequeue();
            smallerNumbers.Enqueue(element, -element);
        }
    }

    public double FindMedian()
    {
        var smallElement = smallerNumbers.Peek();
        if (smallerNumbers.Count > biggerNumbers.Count)
        {
            return smallElement;
        }
        var bigElement = biggerNumbers.Peek();
        return (smallElement + bigElement) / 2.0;
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */