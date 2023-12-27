using System;
using System.Collections.Generic;

public class QueueExample
{
    private Queue<string> myQueue;

    public QueueExample()
    {
        myQueue = new Queue<string>();
    }

    public void EnqueueElement(string element)
    {
        myQueue.Enqueue(element);
    }

    public string DequeueElement()
    {
        return myQueue.Dequeue();
    }

    public string PeekAtFrontElement()
    {
        return myQueue.Peek();
    }

    public bool ContainsElement(string element)
    {
        return myQueue.Contains(element);
    }

    public void ClearQueue()
    {
        myQueue.Clear();
    }

    public void DisplayQueue()
    {
        Console.WriteLine("Queue elements:");
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
