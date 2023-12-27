using System;
using System.IO;

public class FileOps
{
    public static void ReadTextFile(string filePath)
    {
       
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
        else
        {
            Console.WriteLine($"File '{filePath}' does not exist.");
        }
    }

    public static void WriteTextFile(string filePath, string[] lines)
    {
        
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (string line in lines)
            {
                writer.WriteLine(line);
            }
        }

        Console.WriteLine($"File '{filePath}' created with content.");
    }

    public static void CheckFileExistence(string filePath)
    {
        
        if (File.Exists(filePath))
        {
            Console.WriteLine($"File '{filePath}' exists.");
        }
        else
        {
            Console.WriteLine($"File '{filePath}' does not exist.");
        }
    }

    public static void CreateFile(string filePath)
    {
       
        File.Create(filePath).Close();
        Console.WriteLine($"File '{filePath}' created.");
    }

    public static void DeleteFile(string filePath)
    {
        
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            Console.WriteLine($"File '{filePath}' deleted.");
        }
        else
        {
            Console.WriteLine($"File '{filePath}' does not exist.");
        }
    }

    public static void MoveFile(string sourceFilePath, string destinationFilePath)
    {
        
        if (File.Exists(sourceFilePath))
        {
            File.Move(sourceFilePath, destinationFilePath);
            Console.WriteLine($"File '{sourceFilePath}' moved (renamed) to '{destinationFilePath}'.");
        }
        else
        {
            Console.WriteLine($"File '{sourceFilePath}' does not exist.");
        }
    }
}
