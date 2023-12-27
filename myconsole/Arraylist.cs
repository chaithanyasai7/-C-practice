using System;
using System.Collections;

public class ArrayListExample
{
    private ArrayList arrayList;

    public ArrayListExample()
    {
       
        arrayList = new ArrayList();
    }

    public void AddElement(object element)
    {
        
        arrayList.Add(element);
    }

    public void InsertElement(int index, object element)
    {
        
        arrayList.Insert(index, element);
    }

    public void RemoveElement(object element)
    {
        
        arrayList.Remove(element);
    }

    public void RemoveElementAt(int index)
    {
        
        arrayList.RemoveAt(index);
    }

    public bool ContainsElement(object element)
    {
       
        return arrayList.Contains(element);
    }

    public int IndexOfElement(object element)
    {
        
        return arrayList.IndexOf(element);
    }

    public void ClearList()
    {
        
        arrayList.Clear();
    }

    public void DisplayList()
    {
        
        Console.WriteLine("ArrayList elements:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
