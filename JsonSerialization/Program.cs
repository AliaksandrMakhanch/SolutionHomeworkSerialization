using JsonSerialization;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Department dept = new Department { DepartmentName = "Finance" };

        string jsonString = JsonSerializer.Serialize(dept);
        File.WriteAllText("Department.json", jsonString);

        jsonString = File.ReadAllText("Department.json");
        Department deserialized = JsonSerializer.Deserialize<Department>(jsonString);

        Console.WriteLine($"Department: {deserialized.DepartmentName}");
    }
}