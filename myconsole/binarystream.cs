using System;
using System.IO;

public class BinaryStream
{
    public static void ReadWriteWithBinaryReaderWriter(string filePath)
    {
      
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(42);                
            writer.Write(3.14);             
            writer.Write("BinaryWriter");    
        }

       
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            int integerValue = reader.ReadInt32();
            double doubleValue = reader.ReadDouble();
            string stringValue = reader.ReadString();

            Console.WriteLine($"Integer: {integerValue}");
            Console.WriteLine($"Double: {doubleValue}");
            Console.WriteLine($"String: {stringValue}");
        }
    }
}
