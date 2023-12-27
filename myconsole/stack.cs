using System;
using System.Collections.Generic;

public class StackExample
{
    private Stack<string> stack;

    public StackExample()
    {
        stack = new Stack<string>();
    }

    public void PushElement(string element)
    {
        stack.Push(element);
    }

    public string PopElement()
    {
        return stack.Pop();
    }

    public string PeekAtTopElement()
    {
        return stack.Peek();
    }

    public bool ContainsElement(string element)
    {
        return stack.Contains(element);
    }

    public void ClearStack()
    {
        stack.Clear();
    }

    public void DisplayStack()
    {
        Console.WriteLine("Stack elements:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
