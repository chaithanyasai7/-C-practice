using System;

class DataTypes
{
    public void PrintDataTypes()
    {     
        byte myByte = 251;
        int myInt = 82;
        long myLong = 3445677;
        float myFloat = 12.40F;  
        double myDouble = 6.14;       
        char myChar = 'C';       
        bool isTrue = false;      
        string myString = "iam jr.software engineer";
        int? nullableInt = null;    
        Console.WriteLine($"Byte: {myByte}");
        Console.WriteLine($"Int: {myInt}");
        Console.WriteLine($"Double: {myDouble}");
        Console.WriteLine($"Char: {myChar}");
        Console.WriteLine($"Bool: {isTrue}");
        Console.WriteLine($"String: {myString}");
        Console.WriteLine($"Nullable Int: {nullableInt}");
        Console.WriteLine($"Long:{myLong}");
        Console.WriteLine($"float:{myFloat}");
    }
}
