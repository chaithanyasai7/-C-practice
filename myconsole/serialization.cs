using System;
using System.IO;
using System.Xml.Serialization;

public class person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public static class Serialization
{
    public static void SerializePerson(Person person, string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Person));

        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            serializer.Serialize(fs, person);
        }
    }

    public static Person DeserializePerson(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Person));

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            return (Person)serializer.Deserialize(fs);
        }
    }
}


