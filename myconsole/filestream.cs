using System;
using System.IO;

class FileStreamExample
{
    public static void WriteAndReadFile(string filePath)
    {
       
        File.WriteAllText(filePath, "Hello, chaithanya!");

        Console.WriteLine("Data written to the file.");

        
        string readMessage = File.ReadAllText(filePath);

        Console.WriteLine($"Data read from the file: {readMessage}");
    }
}
