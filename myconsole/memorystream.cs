using System.IO;
using System.Text;

public class MemoryExample
{
    public static string WriteAndReadMemory()
    {
        using (MemoryStream memoryStream = new MemoryStream())
        {
           
            byte[] data = Encoding.UTF8.GetBytes("Hello, chaithanya!");
            memoryStream.Write(data, 0, data.Length);

            
            memoryStream.Position = 0; 
            StreamReader reader = new StreamReader(memoryStream);
            return reader.ReadToEnd();
        }
    }
}
