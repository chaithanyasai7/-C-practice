using System;
using System.IO;
using System.Xml.Serialization;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public static class Deserialization
{
    public static Person DeserializePerson()
    {
        
        XmlSerializer serializer = new XmlSerializer(typeof(Person));

      
        using (FileStream fs = new FileStream("person.xml", FileMode.Open))
        {
            return (Person)serializer.Deserialize(fs);
        }
    }
}
