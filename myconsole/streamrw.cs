using System;
using System.IO;

public class StreamRW
{
    public static void ReadWriteWithStreamReaderWriter(string filePath)
    {
        
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Hello, chaithanya!");
            writer.WriteLine("you are jr.software engineer");
        }

        
        using (StreamReader reader = new StreamReader(filePath))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine("Content from StreamReader:");
            Console.WriteLine(content);
        }
    }
}
