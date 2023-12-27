using System;
using System.Collections;

public class HashtableExample
{
    private Hashtable hashtable;

    public HashtableExample()
    {
        
        hashtable = new Hashtable();
    }

    public void AddKeyValuePair(object key, object value)
    {
        
        hashtable.Add(key, value);
    }

    public void UpdateValueForKey(object key, object value)
    {
        
        hashtable[key] = value;
    }

    public bool DoesKeyExist(object key)
    {
        
        return hashtable.ContainsKey(key);
    }

    public void RemoveKeyValuePair(object key)
    {
        
        hashtable.Remove(key);
    }

    public void ClearHashtable()
    {
        
        hashtable.Clear();
    }

    public void DisplayHashtable()
    {
        
        Console.WriteLine("Hashtable key-value pairs:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
        Console.WriteLine();
    }
}
