using System;
using System.IO;

public class BufNWExample
{
    public static void ReadFileWithBufferedStream(string filePath)
    {
        
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        using (BufferedStream bufferedStream = new BufferedStream(fileStream))
        using (StreamReader reader = new StreamReader(bufferedStream))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
