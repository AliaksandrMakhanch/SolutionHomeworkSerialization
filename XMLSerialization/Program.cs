using System.Xml.Serialization;
using XMLSerialization;

class Program
{
    static void Main(string[] args)
    {
        Department dept = new Department { DepartmentName = "Finance" };

        XmlSerializer formatter = new XmlSerializer(typeof(Department));
        using (Stream stream = new FileStream("Department.xml", FileMode.Create, FileAccess.Write))
        {
            formatter.Serialize(stream, dept);
        }

        Department deserialized;
        using (Stream stream = new FileStream("Department.xml", FileMode.Open, FileAccess.Read))
        {
            deserialized = (Department)formatter.Deserialize(stream);
        }

        Console.WriteLine($"Department: {deserialized.DepartmentName}");
    }
}