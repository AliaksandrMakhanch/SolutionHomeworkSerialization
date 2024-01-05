using BinarySerialization;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static void Main(string[] args)
    {
        Department dept = new Department { DepartmentName = "Finance" };

        BinaryFormatter formatter = new BinaryFormatter();
        using (Stream stream = new FileStream("Department.dat", FileMode.Create, FileAccess.Write))
        {
            formatter.Serialize(stream, dept);
        }

        Department deserialized;
        using (Stream stream = new FileStream("Department.dat", FileMode.Open, FileAccess.Read))
        {
            deserialized = (Department)formatter.Deserialize(stream);
        }

        Console.WriteLine($"Department: {deserialized.DepartmentName}");
    }
}
